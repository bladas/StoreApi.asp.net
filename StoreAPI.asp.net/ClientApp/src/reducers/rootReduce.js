import {combineReducers} from "redux";
import {products} from './products';

const rootReduce  = combineReducers(
    {
        products
    }
);
export default rootReduce;
