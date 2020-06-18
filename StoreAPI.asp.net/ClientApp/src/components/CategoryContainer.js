import React, {Component} from 'react';
import connect from "react-redux/es/connect/connect";
import Category from "./Category";
import {setCategoryData} from "../reducers/categoryReducer";



class CategoryContainer extends Component{

    componentDidMount(){
        const id = this.props.match.params.id;
        fetch("https://localhost:44398/api/category/getbyid/"+id)
            .then(response => response.json())
            .then(data =>{
            	// console.log(data)
               this.props.setCategoryData(data)
            })
    }




    render(){

        return <Category {...this.props} />


    }
}

const mapStateToProps = (state) => ({

     data:state.category.data
});


export default connect(mapStateToProps,{setCategoryData})(CategoryContainer);
