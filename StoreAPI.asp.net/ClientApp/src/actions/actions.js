
import React from "react";


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
         }
       })
  }

}



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
        if (data.message) {
         //тут ваша логика
        } else {
          localStorage.setItem("token", data.token)
        }
      })

  }
}
export function loginUser(user) {
    return{
        type:"LOGIN_USER",
        user
    }
}
export function UserFetchData(url) {
    return (dispatch)=> {
        const token = localStorage.token;
     if (token) {
      return fetch(url, {
       method: "GET",
        headers: {
          'Content-Type': 'application/json',
          Accept: 'application/json',
          'token': token
      },


      })
            .then(response => {
                if (!response.ok){
                    throw new Error(response.statusText)
                }
                return response
            })
            .then(response => response.json())

            .then(data => console.log(data))
            .then(user => dispatch(loginUser(user)))
    }
}
}
// export function loginUser(user) {
//     return{
//         type:"LOGIN_USER",
//         user
//     }
// }
// // "https://localhost:44398/api/account/getuserbytoken"
// export function UserFetchData(url){
//   return (dispatch) => {
//     const token = localStorage.token;
//
//     if (token) {
//       return fetch(url, {
//        method: "GET",
//         headers: {
//           'Content-Type': 'application/json',
//           Accept: 'application/json',
//           'token': token
//       },
//
//
//       })
//         .then(resp => resp.json())
//           // .then(data=>console.log(data))
//         .then(data => dispatch(loginUser(data)))
//
//
//           // if (data.message) {
//           //   // Будет ошибка если token не дествительный
//           //   localStorage.removeItem("token")
//           // } else {
//
//
//   //         }
//   //       })
//   //   }
//   // }
// }}}


