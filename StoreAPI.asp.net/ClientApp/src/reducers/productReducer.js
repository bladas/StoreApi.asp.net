const SET_PRODUCT_DATA= "SET_PRODUCT_DATA"
let initialState=[]


const productReducer = (state=initialState,action)=>{
    switch (action.type) {

        case SET_PRODUCT_DATA:
            // console.log(action.user)
             return {
                    ...state,
                    ...action.data,

                        };

        default:
      return state
    }
};
export const setProductData = (data) =>({type:SET_PRODUCT_DATA,data:{data} });
export default productReducer;

