import React from 'react';
import ReactDOM from 'react-dom';
import { BrowserRouter } from 'react-router-dom';
import App from './App';
import * as serviceWorker from './serviceWorker';
import {Provider} from 'react-redux';
import {applyMiddleware,createStore} from "redux";
import thunk from "redux-thunk";
import {composeWithDevTools} from "redux-devtools-extension";
import rootReducer from "./reducers/rootReduce"
import 'jquery';
import Popper from 'popper.js';
import 'bootstrap/dist/js/bootstrap.bundle.min';
import './static/css/bootstrap.min.css';
import './static/css/slick.css';
import './static/css/slick-theme.css';
import './static/css/nouislider.min.css';
import 'font-awesome/css/font-awesome.min.css';
import './static/css/style.css';
import './static/js/main'

const store = createStore(
    rootReducer,
        composeWithDevTools(applyMiddleware(thunk))
);
ReactDOM.render(
      <Provider store={store}>
        <App/>
      </Provider>,document.getElementById('root')
);

// If you want your app to work offline and load faster, you can change
// unregister() to register() below. Note this comes with some pitfalls.
// Learn more about service workers: https://bit.ly/CRA-PWA
serviceWorker.unregister();
