const SET_USER_DATA= "SET_USER_DATA"
let initialState={
    email: null,
    firstName: null,
    id: null,
    lastName: null,
    password: null,
    phoneNumber: null,
    role: null,
    userName: null,
    isAuth:false

}


const authReducer = (state=initialState,action)=>{
    switch (action.type) {

        case SET_USER_DATA:
            // console.log(action.user)
             return {
                    ...state,
                    ...action.data,
                    isAuth:true
                        };

        default:
      return state
    }
};
export const setUserData = (data) =>({type:SET_USER_DATA,data:{data} });
export default authReducer;

