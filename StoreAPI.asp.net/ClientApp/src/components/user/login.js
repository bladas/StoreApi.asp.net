import React, {Component} from 'react';
import {connect} from 'react-redux';
import {userLoginFetch} from '../../actions/actions';


class Login extends Component {
  state = {
    Email: "",
    Password: ""
  }
toggleHover() {
    setTimeout(function () {
        this.setState({ hover: !this.state.hover });
        if (localStorage.token){
          this.props.history.push('/home')
            window.location.reload();
      }
    }.bind(this), 500);
}
  handleChange = event => {
    this.setState({
      [event.target.name]: event.target.value
    });
  }

  handleSubmit = event => {
    event.preventDefault()
    this.props.userLoginFetch(this.state)
    this.toggleHover();

  }

  render() {
    return (
        <div className="section">

		<div className="container">

			<div className="row">
              <div className="col-md-12 text-center">
                <h1>Login</h1>
              </div>
               <div className="col-md-12 text-center">
      <form onSubmit={this.handleSubmit}>

<div className="col-md-12">
  <div className="col-md-4"></div>
       <div className="col-md-1"><label>Email :</label></div>
        <div className="col-md-1"> <input
          name='Email'
          placeholder='email'
          value={this.state.Email}
          onChange={this.handleChange}
          /><br/></div>
</div>
<div className="col-md-12">
  <div className="col-md-4"></div>
  <div className="col-md-1">
        <label>Password:</label>
    </div>
  <div className="col-md-1">
        <input
          type='password'
          name='Password'
          placeholder='Password'
          value={this.state.Password}
          onChange={this.handleChange}
          />
  </div>
  <br/>

</div>
          <button type='submit'>Submit</button>
      </form>
               </div>
            </div>
        </div>
        </div>
    )
  }
}

const mapDispatchToProps = dispatch => ({
  userLoginFetch: userInfo => dispatch(userLoginFetch(userInfo))
})

export default connect(null, mapDispatchToProps)(Login);