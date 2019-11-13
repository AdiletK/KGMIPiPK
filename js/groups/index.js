import React from 'react';
import ReactDOM from 'react-dom';
import { Card } from 'react-bootstrap';
import BootstrapTable from 'react-bootstrap-table-next';

const div = document.getElementById("app");

export function run(init) {
    ReactDOM.render(<Groups data={init} />, div);
}


const Groups = (props) => {

    return (
        <Card>
            <Card.Body>
                <Card.Title>Список групп</Card.Title>
                <BootstrapTable
                    bootstrap4
                    keyField="id"
                    data={ props.data }
                    columns={ columns }
                    bordered={false}
                    noDataIndication="Пусто :["
                    hover
                />
            </Card.Body>
        </Card>
    );
}

const columns = [
    {
        dataField: 'value',
        text: 'Группа',
    },
    {
        format: (cell, row, rowIndex, formatExtraData) => {
            return (
                <a class="icon" href="/Groups/edit/${row.id}" ><i class="zi-edit-pencil"></i></a>
            );
        }
    }
];


