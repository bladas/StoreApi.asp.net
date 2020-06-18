const SET_CATEGORY_DATA= "SET_CATEGORY_DATA"
let initialState=[]


const categoryReducer = (state=initialState,action)=>{
    switch (action.type) {

        case SET_CATEGORY_DATA:
            // console.log(action.user)
             return {
                    ...state,
                    ...action.data,

                        };

        default:
      return state
    }
};
export const setCategoryData = (data) =>({type:SET_CATEGORY_DATA,data:{data} });
export default categoryReducer;

