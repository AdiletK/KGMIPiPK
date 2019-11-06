import ReactDOM from 'react-dom'
import React from 'react'
import StudentForm from './student';


const div = document.getElementById("app");

export function run(init) {
    ReactDOM.render(
        <div className="row">
            <StudentForm data={init} />
        </div>, div);
}
