import React, {Component} from 'react';
import './App.css';
import {connect} from 'react-redux'
import {ProductsFetchData} from "./actions/products";

class App extends Component{

    componentDidMount(){
    this.props.fetchData('https://localhost:44398/api/product/getallproducts/')
    }
    render(){
        return(
            <div>
                <ul>
                    {this.props.products.map((product , index)=>{
                        return <li key = {index}>
                            <div>Name is : {product.name}</div>
                            <div>Name is : {product.shortDescription}</div>
                            <div>Name is : {product.price}</div>
                        </li>
                    }

                    )}

                </ul>
            </div>
        );
    }
}
const mapStateToProps = state => {
    return{
        products: state.products
    };
};
const mapDispatchToProps = dispatch => {
    return{
        fetchData: url => dispatch(ProductsFetchData(url))
    };
};
export default connect(mapStateToProps,mapDispatchToProps)(App);
