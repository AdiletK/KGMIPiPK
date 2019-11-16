import React from 'react';
import { Card } from 'react-bootstrap';
import { Table, Input } from '../components'
import axios from 'axios';
import routes from '../routes';

const updatePrisutstvie = async (row) => {
    await axios.put(routes.updateStudentPrisutstvie + row.nom, row).catch(error => console.log('error:', error));
}

const Lextures = (props) => {

    return (
        <>
            <Card>
                <Card.Body>
                    <Card.Title>Журнал посещения</Card.Title>
                    <Table
                        columns={columns}
                        data={props.data}
                        keyField='nom'
                        cellEdit={true}
                        cellEditSettings={{
                            mode: 'click',
                            blurToSave: true,
                                afterSaveCell: (oldValue, newValue, row, column) => {
                                    if (newValue == '') {
                                        row.prim = null;
                                    }

                                    if (row.prim != oldValue) {
                                        updatePrisutstvie(row);
                                    }
                                }
                        }}
                    />
                </Card.Body>
            </Card>
        </>
    );
}

const columns = [
    {
        dataField: 'student',
        text: 'Студент',
        editable: false
    }, {
        dataField: 'prisutstvie',
        text: 'Присутствие',
        headerAlign: 'center',
        align: 'center',
        editable: false,
        formatter: CheckBoxFormatter,
        headerStyle: (colum, colIndex) => {
            return { width: '50px' };
        }

    }, {
        dataField: 'prim',
        text: 'Примечание',
        headerStyle: (colum, colIndex) => {
            return { width: '400px' };
        }
    },
];



function CheckBoxFormatter(cell, row, rowIndex, formatExtraData) {

    const checked = cell == '+'

    const onClick = async (e) => {
        row.prisutstvie = e.target.checked == true ? '+' : '-';
        await updatePrisutstvie(row);
        console.log(row);
    }

    return (
        <div className="custom-control custom-checkbox">
            <input type="checkbox" className="custom-control-input" id={row.nom} name='prisutstvie' onClick={onClick} defaultChecked={checked} />
            <label className="custom-control-label" htmlFor={row.nom}></label>
        </div>
    );
}



export default Lextures;
