import React from 'react';
import { Form, Col } from 'react-bootstrap';

const TextArea = React.forwardRef((props, ref) => (
    <Form.Group as={Col} controlId={props.controlid}>
        <Form.Label>{props.title}</Form.Label>
        <Form.Control as="textarea"
            name={props.name}
            rows={props.rows}
            value={props.value}
            onChange={props.handleChange}
            placeholder={props.placeholder}
            ref={ref}
        />
    </Form.Group>

));

export default TextArea;