import React from 'react';
import { Form, Col } from 'react-bootstrap';

const Select = React.forwardRef((props, ref) => (
    <>
        <Form.Group as={Col} controlId={props.controlid}>
            <Form.Label>{props.title}</Form.Label>
            <Form.Control
                name={props.name}
                onChange={props.handleChange}
                ref={ref} as="select">
                <option value=''></option>
                {
                    props.options.map(option => {
                        return (
                            <option key={ option.id } value={ props.LabelValue ? option.value : option.id }>{ option.value }</option>
                        );
                    })
                }
            </Form.Control>
        </Form.Group>
    </>
));

export default Select;