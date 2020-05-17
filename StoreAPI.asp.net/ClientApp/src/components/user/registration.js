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
  }

  render() {
    return (
      <form onSubmit={this.handleSubmit}>
        <h1>Sign Up For An Account</h1>

        <label>FirstName</label>
        <input
          name='FirstName'
          placeholder='First Name'
          value={this.state.FirstName}
          onChange={this.handleChange}
          /><br/>

        <label>LastName</label>
        <input
          type='LastName'
          name='LastName'
          placeholder='LastName'
          value={this.state.LastName}
          onChange={this.handleChange}
          /><br/>

        <label>Email</label>
          <input
            name='Email'
            placeholder='Email'
            value={this.state.Email}
            onChange={this.handleChange}
            /><br/>
        <label>PhoneNumber</label>
          <input
            name='PhoneNumber'
            placeholder='PhoneNumber'
            value={this.state.PhoneNumber}
            onChange={this.handleChange}
            /><br/>
          <label>Password</label>
          <input
            name='Password'
            placeholder='Password'
            value={this.state.Password}
            onChange={this.handleChange}
            /><br/>
          <label>ConfirmPassword</label>
          <input
            name='ConfirmPassword'
            placeholder='ConfirmPassword'
            value={this.state.ConfirmPassword}
            onChange={this.handleChange}
            /><br/>


        <input type='submit'/>
      </form>
    )
  }
}

const mapDispatchToProps = dispatch => ({
  userPostFetch: userInfo => dispatch(userPostFetch(userInfo))
})

export default connect(null, mapDispatchToProps)(Signup);