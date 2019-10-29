import axios from 'axios';
import React, { useEffect, useState, useRef } from 'react';
import { Col, Form } from 'react-bootstrap';
import DayPickerInput from 'react-day-picker/DayPickerInput';
import 'react-day-picker/lib/style.css';
import { formatDate, parseDate } from 'react-day-picker/moment';
import useForm from "react-hook-form";
import Button from '../components/Button';
/* Import Components */
import Input from '../components/Input';
import Select from '../components/Select';
import TextArea from '../components/TextArea';
import Alert from '../components/Alert';
import Search from './search';



const FORMAT = 'DD/MM/YYYY';

function StudentForm(props) {
    // init select field data
    const [courseOptions, setCourses] = useState(props.data.items.course);
    const [nationOptions, setNations] = useState(props.data.items.nationality);
    const [regionOptions, setRegions] = useState(props.data.items.region);
    const [sexOptions, setSexes] = useState(props.data.items.sex);
    const [postOptions, setPosts] = useState(props.data.items.post);
    const [educationOptions, setEducations] = useState(props.data.items.education);
    const [headOptions, setHeads] = useState(props.data.items.head);

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
            .finally(setAlert('success','Данные студента обновлены'))
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

    //////


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


    const fillForm = (data) => {
        console.log(data);

        //date
        if (data.dateBorn !== null)
            setDate(data.dateBorn);
        else
            setDate('');


        //district
        //settlement
        //work place
        //course 
        // group


        //specialnost
        //university

        reset({

            name: data.name,
            surname: data.surname,
            lastname: data.lastname,
            sex: data.sex,
            nationality: data.nationality,
            birthPlace: data.birthPlace,
            idnumber: data.idnumber,
            addressStudent: data.addressStudent,
            telefon: data.telefon,
            wPhone: data.wPhone,
            hPhone: data.hPhone,
            post: data.post,
            head: data.head,
            stagObsh: data.stagObsh,
            stagPoSpec: data.stagPoSpec,
            godOkoncaniya: data.godOkoncaniya,
            obrazovanie: data.obrazovanie
        });
    }


    //setting groups
    const handleCourse = async (e) => {
        if (e.target.value !== '') {
            await axios.get("api/student/groups/" + e.target.value)
                .then(response => setGroups(response.data))
                .catch(error => console.log('error:', error))
        }
    }

    //setting districts
    const handleRegion = async (e) => {
        setValue('district', '')
        setValue('settlement', '');
        setValue('uchregdenie', '');

        setSettelents([]);
        setWorks([]);
        if (e.target.value !== '') {
           await axios.get("api/student/districts/" + e.target.value)
                .then(response => setDistricts(response.data))
                .catch(error => console.log('error:', error))
        }
    }


    //setting settlements and lpu's
    const handleDistrict = async (e) => {
        var district = e.target.value;

        if (e.target.value !== '') {
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
                        <Search setStudentID={setStudentID} ref={searchComponent}/>
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
                        <Input inputtype={'text'} title={'Отчество'} name={'lastname'} placeholder={'Введите отчество'} ref={register}/>
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
                        <Select title={'Область'} name={'birthPlace'} options={regionOptions} handleChange={handleRegion} LabelValue={true} ref={register}/>
                        <Select title={'Район'} name={'district'} options={districtOptions} handleChange={handleDistrict} ref={register}/>
                    </Form.Row>

                    <Form.Row >
                        <Select title={'Населенный пункт'} name={'settlement'} options={settlementOptions} ref={register}/>
                        <Input inputtype={'number'} title={'ИНН'} name={'idnumber'} placeholder={'ИНН'} ref={register}/>
                    </Form.Row>

                    <Form.Row >
                        <TextArea title={'Адрес проживания'} rows={2} name={'addressStudent'} placeholder={'Введите адрес'} ref={register}/>
                    </Form.Row>

                    <hr />

                    <Form.Row>
                        <Input inputtype={'number'} title={'Телефон'} name={'telefon'} placeholder={'0550-12-34-56'} ref={register}/>
                    </Form.Row>

                    <Form.Row >
                        <Input inputtype={'number'} title={'Телефон (раб)'} name={'wPhone'} placeholder={'12-34-56'} ref={register}/>
                        <Input inputtype={'number'} title={'Телефон (дом)'} name={'hPhone'} placeholder={'12-34-56'} ref={register}/>
                    </Form.Row>

                    <hr />

                    <Form.Row >
                        <Select title={'Место работы'} name={'uchregdenie'} options={workOptions} ref={register}/>
                    </Form.Row>

                    <Form.Row>
                        <Select title={'Должность'} name={'post'} options={postOptions} ref={register}/>
                        <Select title={'Руководитель'} name={'head'} options={headOptions} ref={register}/>
                    </Form.Row>

                    <Form.Row >
                        <Input inputtype={'number'} title={'Стаж (общий)'} name={'stagObsh'} placeholder={''} ref={register}/>
                        <Input inputtype={'number'} title={'Стаж (по специальности)'} name={'stagPoSpec'} placeholder={''} ref={register}/>
                    </Form.Row>

                    <hr />

                    <Form.Row >
                        <Select title={'Образование'} name={'obrazovanie'} options={educationOptions} ref={register}/>
                        <Select title={'Учебное заведение'} name={'vuz'} options={universityOptions} ref={register}/>
                    </Form.Row>

                    <Form.Row >
                        <Select title={'Специальность'} name={'specialnost'} options={specialityOptions} ref={register}/>
                        <Input inputtype={'number'} title={'Год окончания'} name={'godOkoncaniya'} placeholder={''} ref={register}/>
                    </Form.Row>

                </Form>
            </div>

            <div className="col-md-3 order-md-2 mb-4">
                <h6> Тут может быть полезный текст :] </h6>
                <Button title={'Новый слушатель'} onClick={ handleSubmit(onSubmit) } variant={'outline-primary'} type="submit" block />
                <Button title={'Сохранить изменения'} onClick={ updateStudent } variant={'outline-success'} block />
                <Button title={'Очистить форму'} onClick={ clearForm } variant="outline-secondary" block/>
                <Button title={'Удалить слушателя'} onClick={ deleteStudent } variant={'outline-danger'} block />
                <br />
                <h6> Связанные формы </h6>
                <Button title={'Мед учреждения'} variant={'outline-secondary'} block />
                <Button title={'Должности'} href="/posts" variant={'outline-secondary'} block />
                <Button title={'Руководящие должности'} variant={'outline-secondary'} block />
                <Button title={'Курсы - Группы'}  variant={'outline-secondary'} block />
            </div>
        </>
    );
}


export default StudentForm;
