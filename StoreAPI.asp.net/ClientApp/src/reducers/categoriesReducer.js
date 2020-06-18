const SET_CATEGORIES_DATA= "SET_CATEGORIES_DATA"
let initialState=[]


const categoriesReducer = (state=initialState,action)=>{
    switch (action.type) {

        case SET_CATEGORIES_DATA:
            // console.log(action.user)
             return {
                    ...state,
                    ...action.data,

                        };

        default:
      return state
    }
};
export const setCategoriesData = (data) =>({type:SET_CATEGORIES_DATA,data:{data} });
export default categoriesReducer;

