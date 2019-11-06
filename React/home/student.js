import React, { useEffect, useState, useRef } from 'react';
import { Col, Form } from 'react-bootstrap';

import DayPickerInput from 'react-day-picker/DayPickerInput';
import 'react-day-picker/lib/style.css';
import { formatDate, parseDate } from 'react-day-picker/moment';

import useForm from "react-hook-form";
import Search from './search';
import axios from 'axios';
import { Input, Select, TextArea, Alert, Button } from '../components';

const FORMAT = 'DD/MM/YYYY';

function StudentForm(props) {

    console.log(props.data);

    // init select field data
    const [courseOptions, setCourses] = useState(props.data.course);
    const [nationOptions, setNations] = useState(props.data.nationality);
    const [regionOptions, setRegions] = useState(props.data.region);
    const [sexOptions, setSexes] = useState(props.data.sex);
    const [postOptions, setPosts] = useState(props.data.post);
    const [educationOptions, setEducations] = useState(props.data.education);
    const [headOptions, setHeads] = useState(props.data.head);

    const [groupOptions, setGroups] = useState([]);
    const [universityOptions, setUniversities] = useState([]);
    const [districtOptions, setDistricts] = useState([]);
    const [specialityOptions, setSpecialities] = useState([]);
    const [workOptions, setWorks] = useState([]);
    const [settlementOptions, setSettelents] = useState([]);

    const { handleSubmit, register, errors, setValue, reset, getValues } = useForm();

    //FORM BUTTONS
    const onSubmit = (data, e) => {
        data.dateBorn = date;
        console.log(data);
        console.log(date);

        axios.post('api/student', data)
            .finally(clearForm)
            .finally(setAlert('success', 'Новый студент добавлен'))
            .then(response => console.log(response))
            .catch(error => console.log('error:', error));
    };

    const updateStudent = async () => {
        var data = getValues();
        data.dateBorn = date;
        data.number = studentID;
        await axios.put("api/student/" + studentID, data)
            .finally(setAlert('success', 'Данные студента обновлены'))
            .catch(error => console.log('error:', error))
    };

    const clearForm = () => {
        reset();
        setDate('');
        searchComponent.current.clearInput();
        setStudentID(null)
    };

    const deleteStudent = () => {
        axios.delete("api/student/" + studentID)
            .finally(clearForm)
            .finally(setAlert('success', 'Студент удален из базы данных'))
            .catch(error => console.log('error:', error));
    };

    //////////



    // handle day pick change
    const [date, setDate] = useState('');
    const handleDate = (selectedDate) => {
        setDate(formatDate(selectedDate, FORMAT));
    }

    //SEARCH COMPONENT
    const [studentID, setStudentID] = useState('');
    const searchComponent = useRef(null);
    useEffect(() => {
        //get student and update form with student data
        if (studentID) {
            axios.get("api/student/" + studentID)
                .then(response => fillForm(response.data))
                .catch(error => console.log('error:', error));
        }
    }, [studentID]);
    ////////////////////

    const fillForm = async (data) => {
        console.log(data);

        //date
        if (data.dateBorn !== null)
            setDate(data.dateBorn);
        else
            setDate('');

        //district
        await settingDistricts(data.birthPlace);

        //settlement and lpu
        await settingSettlementsAndLpu(data.district);

        // course
        var courseId = await findCourse(data.grup);

        await reset({

            course: courseId,
            grup: data.grup,
            settlement: data.settlement,
            uchregdenie: data.uchregdenie,

            name: data.name,
            surname: data.surname,
            lastname: data.lastname,
            sex: data.sex,
            nationality: data.nationality,
            birthPlace: data.birthPlace,
            district: data.district,
            idNumber: data.idNumber,
            addressStudent: data.addressStudent,
            telefon: data.telefon,
            wPhone: data.wPhone,
            hPhone: data.hPhone,
            post: data.post,
            head: data.head,
            stagObsh: data.stagObsh,
            stagPoSpec: data.stagPoSpec,
            godOkoncaniya: data.godOkoncaniya,
            obrazovanie: data.obrazovanie,
            vuz: data.vuz,
            specialnost: data.specialnost
        });
    }


    //find course
    const findCourse = async (value) => {
        var course;
        if (value !== '' && value != null) {
            await axios.get("api/student/course/" + value)
                .then(response => course = response.data.id)
                .catch(error => console.log('error:', error))

            await axios.get("api/student/groups/" + course)
                .then(response => setGroups(response.data))
                .catch(error => console.log('error:', error))

        }
        return course;
    }

    //setting groups
    const handleCourse = async (e) => {
        console.log('handle course')
        if (e.target.value !== '') {
            await axios.get("api/student/groups/" + e.target.value)
                .then(response => setGroups(response.data))
                .catch(error => console.log('error:', error))
        }
    }

    //setting districts
    const handleRegion = async (e) => {
        await settingDistricts(e.target.value);
    }

    const settingDistricts = async (value) => {
        setValue('district', '')
        setValue('settlement', '');
        setValue('uchregdenie', '');

        setSettelents([]);
        setWorks([]);
        if (value !== '') {
            await axios.get("api/student/districts/" + value)
                .then(response => setDistricts(response.data))
                .catch(error => console.log('error:', error))
        }
    }

    //setting settlements and lpu's
    const settingSettlementsAndLpu = async (value) => {

        if (value !== '') {
            var district = value;

            await axios.get("api/student/settlements/" + district)
                .then(response => setSettelents(response.data))
                .catch(error => console.log('error:', error))

            await axios.get("api/student/lpus/" + district)
                .then(response => setWorks(response.data))
                .catch(error => console.log('error:', error))
        } else {
            setValue('settlement', '');
            setValue('uchregdenie', '');
            setSettelents([]);
            setWorks([]);
        }
    }

    const handleDistrict = async (e) => {
        await settingSettlementsAndLpu(e.target.value);
    }

    //Alert
    const alert = useRef(null);
    const setAlert = (variant, head, time = 5000) => {
        alert.current.change(true, variant, head)

        setTimeout(() => { alert.current.change(false) }, time);
    }

    return (
        <>
            <div className="col-md-9 order-md-1">
                <Form onSubmit={handleSubmit(onSubmit)} >

                    <Alert ref={alert} />

                    <Form.Group controlId="exampleForm.ControlSelect1">
                        <Form.Label> Студенты </Form.Label>
                        <Search setStudentID={setStudentID} ref={searchComponent} />
                    </Form.Group>

                    <Form.Row>
                        <Select title={'Курс'} name={'course'} options={courseOptions} handleChange={handleCourse} ref={register} />
                        <Select title={'Группа'} controlid={'formGroup'} name={'grup'} options={groupOptions} ref={register} />
                    </Form.Row>

                    <hr />
                    <Form.Row >
                        <Input inputtype={'text'} title={'Фамилия'} name={'surname'} placeholder={'Введите фамилию'} ref={register({ required: true })} />
                        <Input inputtype={'text'} title={'Имя'} name={'name'} placeholder={'Введите имя'} ref={register} />
                    </Form.Row>

                    <Form.Row >
                        <Input inputtype={'text'} title={'Отчество'} name={'lastname'} placeholder={'Введите отчество'} ref={register} />
                        <Select title={'Пол'} name={'sex'} options={sexOptions} ref={register} />
                    </Form.Row>

                    <Form.Row >
                        <Form.Group as={Col}>
                            <Form.Label>Дата рождения</Form.Label><br />
                            <DayPickerInput
                                name="dateborn"
                                inputProps={{ className: 'form-control', block: 'block' }}
                                value={date}
                                onDayChange={handleDate}
                                formatDate={formatDate}
                                format={FORMAT}
                                parseDate={parseDate}
                                placeholder={``}
                            />
                        </Form.Group>

                        <Select title={'Национальность'} name={'nationality'} options={nationOptions} ref={register} />
                    </Form.Row>

                    <Form.Row>
                        <Select title={'Область'} name={'birthPlace'} options={regionOptions} handleChange={handleRegion} LabelValue={true} ref={register} />
                        <Select title={'Район'} name={'district'} options={districtOptions} handleChange={handleDistrict} ref={register} />
                    </Form.Row>

                    <Form.Row >
                        <Select title={'Населенный пункт'} name={'settlement'} options={settlementOptions} ref={register} />
                        <Input inputtype={'number'} title={'ИНН'} name={'idNumber'} placeholder={'ИНН'} ref={register} />
                    </Form.Row>

                    <Form.Row >
                        <TextArea title={'Адрес проживания'} rows={2} name={'addressStudent'} placeholder={'Введите адрес'} ref={register} />
                    </Form.Row>

                    <hr />

                    <Form.Row>
                        <Input inputtype={'number'} title={'Телефон'} name={'telefon'} placeholder={'0550-12-34-56'} ref={register} />
                    </Form.Row>

                    <Form.Row >
                        <Input inputtype={'number'} title={'Телефон (раб)'} name={'wPhone'} placeholder={'12-34-56'} ref={register} />
                        <Input inputtype={'number'} title={'Телефон (дом)'} name={'hPhone'} placeholder={'12-34-56'} ref={register} />
                    </Form.Row>

                    <hr />

                    <Form.Row >
                        <Select title={'Место работы'} name={'uchregdenie'} options={workOptions} ref={register} />
                    </Form.Row>

                    <Form.Row>
                        <Select title={'Должность'} name={'post'} options={postOptions} ref={register} />
                        <Select title={'Руководитель'} name={'head'} options={headOptions} ref={register} />
                    </Form.Row>

                    <Form.Row >
                        <Input inputtype={'number'} title={'Стаж (общий)'} name={'stagObsh'} placeholder={''} ref={register} />
                        <Input inputtype={'number'} title={'Стаж (по специальности)'} name={'stagPoSpec'} placeholder={''} ref={register} />
                    </Form.Row>

                    <hr />

                    <Form.Row >
                        <Select title={'Образование'} name={'obrazovanie'} options={educationOptions} ref={register} />
                        <Input inputtype={'text'} title={'Учебное заведение'} name={'vuz'} placeholder={'Учебное заведение'} ref={register} />
                    </Form.Row>

                    <Form.Row >
                        <Input inputtype={'text'} title={'Специальность'} name={'specialnost'} placeholder={'Специальность'} ref={register} />
                        <Input inputtype={'number'} title={'Год окончания'} name={'godOkoncaniya'} placeholder={''} ref={register} />
                    </Form.Row>

                </Form >
            </div >

            <div className="col-md-3 order-md-2 mb-4">
                <Button title={'Новый слушатель'} onClick={handleSubmit(onSubmit)} variant={'outline-primary'} type="submit" block />
                <Button title={'Сохранить изменения'} onClick={updateStudent} variant={'outline-success'} block />
                <Button title={'Очистить форму'} onClick={clearForm} variant="outline-secondary" block />
                <Button title={'Удалить слушателя'} onClick={deleteStudent} variant={'outline-danger'} block />
            </div>
        </>
    );
}

export default StudentForm;