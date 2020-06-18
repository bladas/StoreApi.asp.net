import React, {Component} from 'react'
import {connect} from 'react-redux'
import {userPostFetch} from '../../actions/actions'
class Signup extends Component {
  state = {
    FirstName: "",
    LastName: "",
    Email: "",
    PhoneNumber: "",
    Password: "",
    ConfirmPassword: ""

  }

  handleChange = event => {
    this.setState({
      [event.target.name]: event.target.value
    });
  }

  handleSubmit = event => {
    event.preventDefault()
    this.props.userPostFetch(this.state)
      if (localStorage.token){
          this.props.history.push('/home')

        window.location.reload();
      }
  }

  render() {
    return (
        <div className="section">

		<div className="container">

			<div className="row">
              <div className="text-center">
                 <h1>Sign Up For An Account</h1>
              </div>
       <div className="col-md-12">
      <form onSubmit={this.handleSubmit}>
      <div className="col-md-12">
      <div className="col-md-4"></div>
        <div className="col-md-2">
        <label>FirstName</label>
          </div>
         <div className="col-md-1">
        <input
          name='FirstName'
          placeholder='First Name'
          value={this.state.FirstName}
          onChange={this.handleChange}
        /></div>
          <br/>

      </div>
        <div className="col-md-12">
      <div className="col-md-4"></div>
           <div className="col-md-2">
        <label>LastName</label>
           </div>
           <div className="col-md-1">
        <input
          type='LastName'
          name='LastName'
          placeholder='LastName'
          value={this.state.LastName}
          onChange={this.handleChange}
          />
           </div><br/>
        </div>
          <div className="col-md-12">
      <div className="col-md-4"></div>
             <div className="col-md-2">
        <label>Email</label>
             </div>
             <div className="col-md-1">
          <input
            name='Email'
            placeholder='Email'
            value={this.state.Email}
            onChange={this.handleChange}
            />
             </div><br/>
          </div>
          <div className="col-md-12">
      <div className="col-md-4"></div>
             <div className="col-md-2">
        <label>PhoneNumber</label>
             </div>
             <div className="col-md-1">
          <input
            name='PhoneNumber'
            placeholder='PhoneNumber'
            value={this.state.PhoneNumber}
            onChange={this.handleChange}
            />
             </div><br/>
          </div>
          <div className="col-md-12">
      <div className="col-md-4"></div>
             <div className="col-md-2">
          <label>Password</label>
             </div>
             <div className="col-md-1">
          <input
            name='Password'
            placeholder='Password'
            value={this.state.Password}
            onChange={this.handleChange}
            />
             </div><br/>
          </div>
          <div className="col-md-12">
      <div className="col-md-4"></div>
             <div className="col-md-2">
          <label>ConfirmPassword</label>
             </div>
             <div className="col-md-1">
          <input
            name='ConfirmPassword'
            placeholder='ConfirmPassword'
            value={this.state.ConfirmPassword}
            onChange={this.handleChange}
          /></div><br/>
          </div>
      <div className="text-center">
         <input type='submit' className="btn btn"/>
      </div>

      </form>
          </div>
            </div>
        </div>
        </div>
    )
  }
}

const mapDispatchToProps = dispatch => ({
  userPostFetch: userInfo => dispatch(userPostFetch(userInfo))
})

export default connect(null, mapDispatchToProps)(Signup);