import React from 'react';
import BootstrapTable from 'react-bootstrap-table-next';
import paginationFactory from 'react-bootstrap-table2-paginator';
import cellEditFactory, { Type } from 'react-bootstrap-table2-editor';

const Table = (props) => {
    return (
        <BootstrapTable
            bootstrap4
            keyField={props.keyField}
            data={props.data}
            columns={props.columns}
            bordered={false}
            expandRow={props.expandRow}
            pagination={props.pagination ? paginationFactory() : null}
            noDataIndication="Пусто :["
            cellEdit={props.cellEdit ? cellEditFactory(props.cellEditSettings) : null}
            hover
        />
    );
}



const columns = [{
    dataField: 'id',
    text: 'Product ID'
}, {
    dataField: 'name',
    text: 'Product Name'
}, {
    dataField: 'price',
    text: 'Product Price'
    }];


export default Table;