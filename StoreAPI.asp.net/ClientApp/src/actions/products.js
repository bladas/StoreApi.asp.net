
export function ProductsFetchDataSuccess(products) {
    return{
        type:"PRODUCT_FETCH_DATA_SUCCESS",
        products
    }
}
export function ProductsFetchData(url) {
    return (dispatch)=> {
        fetch(url)
            .then(response => {
                if (!response.ok){
                    throw new Error(response.statusText)
                }
                return response
            })
            .then(response => response.json())
            // .then(products=>console.log(products))
            .then(products => dispatch(ProductsFetchDataSuccess(products)))
    }
}