import React, {Component} from 'react';
import logo from '../static/img/logo.png'
import {UserFetchData} from '../actions/actions'
import MyAccount from "./user/MyAccount";



const Header =(props) => {
function handleClick(event){
        event.preventDefault()

        localStorage.removeItem("token")
        window.location.reload();

    }


    return <header className='header'>
        <div id="top-header">
            <div className="container">
                <ul className="header-links pull-left">
                    <li><a href="#"><i className="fa fa-phone"></i> +012-34-56-79 </a></li>
                    <li><a href="#"><i className="fa fa-envelope-o"></i> email@email.com</a></li>

                </ul>
                <ul className="header-links pull-right">


                    {props.isAuth?

                        (<li><li><a href="/profile"><i className="fa fa-user-o"></i> My Account</a></li>
                        <li><a href="/home" type="logOut" onClick={(event) => handleClick(event)}><i className="fa fa-user-o"></i> Log out</a></li></li>)
                        :(<li><li><a href="/login" ><i className="fa fa-user-o"></i> Login</a></li>
                    <li><a href="/registration"><i className="fa fa-user-o"></i> Registration</a></li></li>)




                    }


                </ul>
            </div>
        </div>

        <div id="header">

            <div className="container">

                <div className="row">

                    <div className="col-md-3">
                        <div className="header-logo">
                            <a href="/home" className="logo">
                                <img src={logo} alt=""></img>
                            </a>
                        </div>
                    </div>

                    <div className="col-md-6">
                        <div className="header-search">
                            <form>
                                <select className="input-select">
                                    <option value="0">All Categories</option>

                                </select>
                                <input className="input" placeholder="Search here"></input>
                                <button className="search-btn">Search</button>
                            </form>
                        </div>
                    </div>


                    <div className="col-md-3 clearfix">
                        <div className="header-ctn">

                            <div>
                                <a href="#">
                                    <i className="fa fa-heart-o"></i>
                                    <span>Your Wishlist</span>
                                    <div className="qty">2</div>
                                </a>
                            </div>


                            <div className="dropdown">
                                <a className="dropdown-toggle" data-toggle="dropdown" aria-expanded="true">
                                    <i className="fa fa-shopping-cart"></i>
                                    <span>Your Cart</span>
                                    <div className="qty">3</div>
                                </a>
                                <div className="cart-dropdown">
                                    <div className="cart-list">
                                        <div className="product-widget">
                                            <div className="product-img">
                                                <img src="./img/product01.png" alt=""></img>
                                            </div>
                                            <div className="product-body">
                                                <h3 className="product-name"><a href="#">product name goes here</a></h3>
                                                <h4 className="product-price"><span className="qty">1x</span>$980.00
                                                </h4>
                                            </div>
                                            <button className="delete"><i className="fa fa-close"></i></button>
                                        </div>

                                        <div className="product-widget">
                                            <div className="product-img">
                                                <img src="./img/product02.png" alt=""></img>
                                            </div>
                                            <div className="product-body">
                                                <h3 className="product-name"><a href="#">product name goes here</a></h3>
                                                <h4 className="product-price"><span className="qty">3x</span>$980.00
                                                </h4>
                                            </div>
                                            <button className="delete"><i className="fa fa-close"></i></button>
                                        </div>
                                    </div>
                                    <div className="cart-summary">
                                        <small>3 Item(s) selected</small>
                                        <h5>SUBTOTAL: $2940.00</h5>
                                    </div>
                                    <div className="cart-btns">
                                        <a href="#">View Cart</a>
                                        <a href="#">Checkout <i className="fa fa-arrow-circle-right"></i></a>
                                    </div>
                                </div>
                            </div>

                            <div className="menu-toggle">
                                <a href="#">
                                    <i className="fa fa-bars"></i>
                                    <span>Menu</span>
                                </a>
                            </div>

                        </div>
                    </div>

                </div>

            </div>

        </div>


        <nav id="navigation">

            <div className="container">

                <div id="responsive-nav">

                    <ul className="main-nav nav navbar-nav">
                        <li><a href="/home">Home</a></li>
                        <li><a href="/all-categories">All Categories</a></li>
                        {/*<li><a href="/product">Product</a></li>*/}



                    </ul>

                </div>

            </div>

        </nav>


    </header>

}
export default Header;

