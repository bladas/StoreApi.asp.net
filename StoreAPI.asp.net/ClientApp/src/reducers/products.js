export function products(state=[],action) {
    switch (action.type) {
        case "PRODUCT_FETCH_DATA_SUCCESS":
            return action.products
        default:
            return state
    }
}