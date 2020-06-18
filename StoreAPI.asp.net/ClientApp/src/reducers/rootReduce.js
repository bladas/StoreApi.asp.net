import {combineReducers} from "redux";
import {products} from './products';
import authReducer from './authReducer';
import categoriesReducer from "./categoriesReducer";
import categoryReducer from "./categoryReducer";
import productReducer from "./productReducer";

const rootReduce  = combineReducers(
    {
        auth:authReducer,
        products:products,
        categories:categoriesReducer,
        category:categoryReducer,
        product:productReducer
    }
);
export default rootReduce;
