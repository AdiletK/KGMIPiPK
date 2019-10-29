import React from 'react';
import { Form, Col } from 'react-bootstrap';

const Input = React.forwardRef((props, ref) => (
    <>
        <Form.Group as={Col} controlId={props.controlid}>
            <Form.Label>{props.title}</Form.Label>
            <Form.Control
                name={props.name}
                type={props.inputType}
                onChange={props.handleChange}
                placeholder={props.placeholder}
                ref={ref}
            />
        </Form.Group>
    </>
));

export default Input;