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
           console.log(data.token)
        if (data.message) {
         //тут ваша логика
        } else {
          localStorage.setItem("token", data.token)
          dispatch(loginUser(data.user))
        }
      })

  }
}
export const getProfileFetch = () => {
  return dispatch => {
    const token = localStorage.token;

    if (token) {
      return fetch("https://localhost:44398/api/account/getuserbytoken", {
       method: "GET",
        headers: {
          'Content-Type': 'application/json',
          Accept: 'application/json',
          'token': token
      },


      })
        .then(resp => resp.json())
        .then(data => {
            console.log(data)
          if (data.message) {
            // Будет ошибка если token не дествительный
            localStorage.removeItem("token")
          } else {
            dispatch(loginUser(data.user))
          }
        })
    }
  }
}
