import React, {Component} from 'react';


const Admin=(props)=> {
  console.log(props)
  return <div>
    {props.isAuth? (
        <div className="section">
            <div className="container">
                <div className="row">
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


    ):(false)}
  </div>
}
export default Admin;