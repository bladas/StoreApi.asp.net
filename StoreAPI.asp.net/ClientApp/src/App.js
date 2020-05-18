import React, {Component} from 'react';
import './App.css';
// import {connect} from 'react-redux'
// import {ProductsFetchData} from "./actions/products";


import Header from "./components/Header";
import Footer from "./components/Footer";
import Home from "./components/Home";
import {BrowserRouter, Route} from "react-router-dom";
import Product from "./components/Product";
import Store from "./components/Store";
import Login from "./components/user/login";
import Register from "./components/user/registration"
import {getProfileFetch} from "./actions/actions";
import {connect} from "react-redux";
class App extends Component {
  componentDidMount = () => {
    this.props.getProfileFetch()
  }
  render() {
    return (
        <BrowserRouter>
            <div className='app-wraper'>
            <Header/>
            <div className='app-wraper-content'>
                <Route path='/home' component={Home}/>
                <Route path='/login' component={Login}/>
                <Route path='/registration' component={Register}/>
                <Route path='/product' component={Product}/>
                <Route path='/store' component={Store}/>


            </div>

            <Footer/>
            </div>
        </BrowserRouter>
    )
}
}
const mapDispatchToProps = dispatch => ({
  getProfileFetch: () => dispatch(getProfileFetch())
})

export default connect(null, mapDispatchToProps)(App);



// class App extends Component{
//
//     componentDidMount(){
//     this.props.fetchData('https://localhost:44398/api/product/getallproducts/')
//     }
//     render(){
//         return(
//             <div>
//                 <ul>
//                     {this.props.products.map((product , index)=>{
//                         return <li key = {index}>
//                             <div>Name is : {product.name}</div>
//                             <div>Name is : {product.shortDescription}</div>
//                             <div>Name is : {product.price}</div>
//                         </li>
//                     }
//
//                     )}
//
//                 </ul>
//             </div>
//         );
//     }
// }
// const mapStateToProps = state => {
//     return{
//         products: state.products
//     };
// };
// const mapDispatchToProps = dispatch => {
//     return{
//         fetchData: url => dispatch(ProductsFetchData(url))
//     };
// };
// export default connect(mapStateToProps,mapDispatchToProps)(App);
