export const userPostFetch = user => {
  return dispatch => {
    return fetch("https://localhost:44398/api/account/register/", {
      method: "POST",
     headers: {
        'Content-Type': 'application/json',
        Accept: 'application/json',
      },
      body: JSON.stringify(user
      )
    })



       .then(resp => resp.json())
       .then(data => {
         if (data.message) {
           //Тут прописываем логику
        } else {
           localStorage.setItem("token", data.token)
           dispatch(loginUser(data.user))
         }
       })
  }

}

const loginUser = userObj => ({
    type: 'LOGIN_USER',
    payload: userObj
})

export const userLoginFetch = user => {
  return dispatch => {
    console.log(JSON.stringify(user))
    return fetch("https://localhost:44398/api/account/login", {
      method: "POST",
      headers: {
        'Content-Type': 'application/json',
        Accept: 'application/json',
      },
      body: JSON.stringify(user)
    })
      .then(resp => resp.json())
      .then(data => {
          // console.log(data.jwt)
        if (data.message) {
         //тут ваша логика
        } else {
          localStorage.setItem("token", data.token)
          dispatch(loginUser(data.user))
        }
      })

  }
}