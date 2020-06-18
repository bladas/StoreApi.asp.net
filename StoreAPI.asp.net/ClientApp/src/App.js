import React, {Component} from 'react';
import './App.css';
import HeaderContainer from "./components/HeaderContainer";
import Footer from "./components/Footer";
import Home from "./components/Home";
import {BrowserRouter, Redirect, Route} from "react-router-dom";
import Login from "./components/user/login";
import Register from "./components/user/registration"
import MyAccountContainer from "./components/user/MyAccountContainer";
import AllCategoriesContainer from "./components/AllCategoriesContainer";
import CategoryContainer from "./components/CategoryContainer";
import ProductContainer from "./components/ProductContainer";
import Admin from "./components/user/Admin";
class App extends Component {


  render() {
    return (
        <BrowserRouter>

            <div className='app-wraper'>
            <HeaderContainer/>
            <div className='app-wraper-content'>
                <Route path='/home' component={Home}/>
                <Route path='/login' component={Login}/>
                <Route path='/registration' component={Register}/>
                <Route path='/product/:id' component={ProductContainer}/>
                <Route path='/all-categories' component={AllCategoriesContainer}/>
                <Route path='/category/:id' component={CategoryContainer}/>
                <Route path='/profile' component={MyAccountContainer}/>
                <Route path='/admin' component = {Admin}/>


            </div>

            <Footer/>
            </div>
        </BrowserRouter>
    )
}
}

export default (App);



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
