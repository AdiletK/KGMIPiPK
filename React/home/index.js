import ReactDOM from 'react-dom'
import React from 'react'
import { Tabs, Tab } from 'react-bootstrap';

//import components
import StudentForm from './student';

var app = document.getElementById("content");

export function run(init) {
    ReactDOM.render(
        <Home items={init} />, app);
}


function Home(props) {

    return (
        <div className="row">
            <StudentForm data={props} />
        </div>
    );

}


//if (module.hot) {
//    module.hot.accept();
//}

