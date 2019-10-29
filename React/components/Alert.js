import React, { useState, Component } from 'react';
import { Alert as BAlert, Button } from 'react-bootstrap';

class Alert extends Component {

    constructor(props) {
        super(props);

        this.state = {
            show: false,
            variant: 'success',
            head: ''
        };
    }

    change(show, variant = 'success', head = '') {
        this.setState({
            show: show,
            variant: variant,
            head: head
        });
    }

    render() {
        if (this.state.show) {
            return (
                <BAlert variant={this.state.variant} onClose={() => this.setState({ show: false })} dismissible>
                    <p> { this.state.head } </p>
                </BAlert>
            );
        }
        return <></>;
    }
}

export default Alert;