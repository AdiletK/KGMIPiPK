import React, { useEffect, useState, useRef } from 'react';
import { Row, Card } from 'react-bootstrap';
import { Select, Button, Table } from '../components'
import axios from 'axios';

const Lextures = (props) => {
    const [teachers, setTeachers] = useState(props.data.teachers);
    const [course, setCoutse] = useState(props.data.course);

    console.log(props.data.lextures);

    return (
        <>
            <h3>
                Занятия
                <Button title={'Добавить'} variant={'outline-dark justify-right'} />
            </h3>
            <Row>
                <Select title={'Курс'} name={'course'} options={course} />
                <Select title={'Преподаватель'} name={'teachers'} options={teachers} />
            </Row>

            <Row>
                <Table columns={columns} data={props.data.lextures} expandRow={expandRow} pagination={true} keyField='id' />
            </Row>
        </>
    );
}

const handleTagClick = rowId => () => {

    console.log(rowId);
    //const newProducts = this.state.products.map((row) => {
    //    if (row.id === rowId) {
    //        row.name += row.name;
    //    }
    //    return row;
    //});
    //this.setState({ products: newProducts });
}



const expandRow = {
    onlyOneExpanding: true,
    renderer: row => (
        <Card>
            <Card.Body>
                <Card.Title>Журнал посещения</Card.Title>
                <Table columns={columns} data={[]} keyField='id' />
                <Button title={'Добавить'} variant={'outline-primary'} />
            </Card.Body>
        </Card>
    )
};



const columns = [
    {
        dataField: 'date',
        text: 'Дата'
    }, {
        dataField: 'group',
        text: 'Группа'
    }, {
        dataField: 'tema',
        text: 'Тема'
    }, {
        dataField: 'teacher',
        text: 'Преподаватель'
    }, {
        dataField: 'vidzan',
        text: 'Вид занятия'
    }, {
        dataField: 'hours',
        text: 'Часов',
    }, {
        dataField: 'Actions',
        text: '',
        formatter: rankFormatter
    }

];

function rankFormatter(cell, row, rowIndex, formatExtraData) {
    console.log(cell);
    console.log(row);
    return (
        < div
            style={{
                textAlign: "center",
                cursor: "pointer",
                lineHeight: "normal"
            }}>
            <Button title={'Изменить'} href={'/lextures/edit/' + row.id } variant={'outline-secondary justify-right'} />
            
        </div>
    );
} 



export default Lextures;





//class Tables extends React.Component {
//    constructor(props) {
//        super(props);
//        this.state = { products };

//        this.columns = [{
//            dataField: 'id',
//            text: 'Product ID'
//        }, {
//            dataField: 'name',
//            text: 'Product Name',
//            filter: textFilter(),
//            formatter: cell => `% ${cell} %`
//        }, {
//            dataField: 'price',
//            text: 'Product Price',
//            formatter: (cell, row) => {
//                return (
//                    <button onClick={this.handleTagClick(row.id)}>Click</button>
//                );
//            }
//        }];
//    }
//    /* eslint no-param-reassign: 0 */
//    handleTagClick = rowId => () => {
//        const newProducts = this.state.products.map((row) => {
//            if (row.id === rowId) {
//                row.name += row.name;
//            }
//            return row;
//        });
//        this.setState({ products: newProducts });
//    }

//    render() {
//        return (
//            <div>
//                <BootstrapTable
//                    keyField="id"
//                    data={this.state.products}
//                    columns={this.columns}
//                    filter={filterFactory()}
//                />
//                <Code>{sourceCode}</Code>
//            </div>
//        );
//    }
//}