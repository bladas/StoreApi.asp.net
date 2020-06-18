import React, {Component} from 'react';

import connect from "react-redux/es/connect/connect";
import {setUserData} from "../reducers/authReducer";
import Header from "./Header";



class HeaderContainer extends Component{
    componentDidMount(){
         const token = localStorage.token;
          if (token) {
              if (token !== 'undefined') {
                  fetch("https://localhost:44398/api/account/getuserbytoken", {
                   method: "GET",
                    headers: {
                      'Content-Type': 'application/json',
                      Accept: 'application/json',
                      'token': token
                  }
                  })
                        .then(response => response.json())

                        .then(data =>{
                            this.props.setUserData(data)
                        })
                }}
                else {
                    localStorage.removeItem(token)
                      }}




    render(){

        return <Header {...this.props} />


    }
}

const mapStateToProps = (state) => ({
    isAuth:state.auth.isAuth,
    data:state.auth.data
});


export default connect(mapStateToProps,{setUserData})(HeaderContainer);
