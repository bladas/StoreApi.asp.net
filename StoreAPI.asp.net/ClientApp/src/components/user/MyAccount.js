import React, {Component} from 'react';
import Header from "../Header";

const MyAccount=(props)=> {
  console.log(props)
  return <div>
    {props.isAuth? (
        <div className="section">
            <div className="container">
                <div className="row">
                        <div className="col-md-12">
                            <div className="col-md-3">Ваша електронна aдреса:</div>
                            <div className="col-md-2">{props.data.email}</div>
                          {props.data.email = "dashkevich_v@ukr.net"?(
                              <div className="Col-md-6">
                                <a href="/admin">
                                  Адмін меню
                                </a>
                              </div>)
                              :(false)}

                        </div>


                </div>
            </div>
        </div>


    ):(false)}
  </div>
}
export default MyAccount;