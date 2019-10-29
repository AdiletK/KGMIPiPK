import axios from 'axios';
import React, { useEffect, useState, useRef } from 'react';
import { Col, Row } from 'react-bootstrap';


/* Import Components */
import Input from '../components/Input';
import Select from '../components/Select';
import TextArea from '../components/TextArea';
import Button from '../components/Button';
import Alert from '../components/Alert';

import DatatablePage from './table';



function Lextures(props) {


    return (
        <>
            <div className="col-md-9 order-md-1">
                <Row>
                    <Select title={'Группа'} name={'group'} options={[]}  />
                    <Select title={'Преподаватель'} name={'course'} options={[]} />
                </Row>

                <DatatablePage/>
                    
            </div>

            <div className="col-md-3 order-md-2 mb-4">
                <h6> Тут может быть полезный текст :] </h6>
                <Button title={'Новое занятие'} variant={'outline-primary'} block />
                <br />
                <h6> Связанные формы </h6>
                <Button title={'Циклы'} variant={'outline-secondary'} block />
                <Button title={'Темы'} variant={'outline-secondary'} block />
                <Button title={'Группы'} variant={'outline-secondary'} block />
                <Button title={'Преподаватели'} variant={'outline-secondary'} block />
                <Button title={'Списки групп'} variant={'outline-secondary'} block />
            </div>
        </>
    );
}


export default Lextures;
