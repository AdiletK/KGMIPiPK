import React from 'react';
import BootstrapTable from 'react-bootstrap-table-next';
import paginationFactory from 'react-bootstrap-table2-paginator';

const Table = (props) => {
    return (
        <BootstrapTable
            bootstrap4
            keyField={ props.keyField }
            data={ props.data }
            columns={ props.columns }
            bordered={false}
            expandRow={ props.expandRow }
            pagination={ props.pagination ? paginationFactory() : null }
            noDataIndication="Пока что данных нет :[" 
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