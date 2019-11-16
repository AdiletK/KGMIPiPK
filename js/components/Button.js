import React from 'react';
import { Button as BootsButton } from 'react-bootstrap';


const Button = (props) => {
    return (
        <>
            <BootsButton variant={props.variant}
                onClick={props.onClick}
                href={props.href}
                {...props}
            >
                {props.title}
            </BootsButton>
        </>
    );
}

export default Button
