import React, { useState, useEffect } from 'react';
import ReactDOM from 'react-dom';
import { Row } from 'react-bootstrap'
import BootstrapTable from 'react-bootstrap-table-next';
import { Select } from '../components';
import axios from 'axios';
import routes from '../routes';

const div = document.getElementById("app");

export function run(init) {
    ReactDOM.render(<GroupLists data={init} />, div);
}


const GroupLists = (props) => {

    const [courses, setCourses] = useState(props.data);
    const [groups, setGroups] = useState([]);
    const [table, setTableData] = useState([]);

    const handleCourse = async (e) => {
        if (e.target.value != '' && e.target.value != null) {
            await axios.get(routes.getGroupsByCourseID + e.target.value)
                .then(response => setGroups(response.data))
                .catch(error => console.log(error));
        } else {
            setGroups([]);
            setTableData([]);
        }
    }

    const handleGroup = async (e) => {
        if (e.target.value != '' && e.target.value != null) {
            await axios.get(routes.getStudentsByGroups + e.target.value)
                .then(response => setTableData(response.data))
                .catch(error => console.log(error));
        } else {
            setTableData([]);
        }
    }


    return (
        <>
            <Row>
                <Select title={'Курс'} name={'course'} options={courses} handleChange={handleCourse} />
                <Select title={'Группы'} name={'group'} options={groups} handleChange={handleGroup} />
            </Row>
            <BootstrapTable
                bootstrap4
                keyField="id"
                data={table}
                columns={columns}
                bordered={false}
                noDataIndication="Выбрите курс и группу."
                hover
            />
        </>
    );
};

const columns = [
    {
        dataField: 'surname',
        text: 'Фамилия',
    },
    {
        dataField: 'name',
        text: 'Имя',
    },
    {
        dataField: 'lastname',
        text: 'Отчество',
    },
    {
        dataField: 'region',
        text: 'Область',
    },
    {
        dataField: 'district',
        text: 'Район',
    },
    {
        dataField: 'settlement',
        text: 'Нас. пункт',
    },
    {
        dataField: 'lpu',
        text: 'Место работы',
    },
    {
        dataField: 'post',
        text: 'Должность',
    },
    {
        dataField: 'head',
        text: 'Руководитель',
    },
  
];


