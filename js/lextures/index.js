import ReactDOM from 'react-dom';
import React from 'react';
import Lextures from './lextures';

const div = document.getElementById("app");

export function run(init) {
    ReactDOM.render(
            <Lextures data={init} />, div);
}
