import React, {Component} from 'react';
import connect from "react-redux/es/connect/connect";
import Product from "./Product";
import {setProductData} from "../reducers/productReducer";



class ProductContainer extends Component{

    componentDidMount(){
        const id = this.props.match.params.id;
        fetch("https://localhost:44398/api/product/getproduct/"+id)
            .then(response => response.json())
            .then(data =>{
            	// console.log(data)
               this.props.setProductData(data)

            })




    }




    render(){

        return <Product {...this.props} />


    }
}

const mapStateToProps = (state) => ({

     data:state.product.data
});


export default connect(mapStateToProps,{setProductData})(ProductContainer);
