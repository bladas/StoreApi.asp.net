import React, {Component} from 'react';
import connect from "react-redux/es/connect/connect";
import AllCategories from "./AllCategories";
import {setCategoriesData} from "../reducers/categoriesReducer";



class AllCategoriesContainer extends Component{

    componentDidMount(){
        fetch("https://localhost:44398/api/category/getallcategories")
            .then(response => response.json())
            .then(data =>{
            	// console.log({data})
               this.props.setCategoriesData(data)

            })




    }




    render(){

        return <AllCategories {...this.props} />


    }
}

const mapStateToProps = (state) => ({

     data:state.categories.data
});


export default connect(mapStateToProps,{setCategoriesData})(AllCategoriesContainer);
