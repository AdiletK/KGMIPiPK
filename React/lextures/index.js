import ReactDOM from 'react-dom'
import React from 'react'

//import components
import Lextures from './lextures';

var div = document.getElementById("content");

export function run(init) {
    ReactDOM.render(
        <App items={init} />, div);
}


function App(props) {

    return (
        <div className="row">
            <Lextures data={props} />
        </div>
    );

}


//if (module.hot) {
//    module.hot.accept();
//}

