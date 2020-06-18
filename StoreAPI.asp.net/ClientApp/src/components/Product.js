import React from 'react';


const Product = (props) =>{
	console.log(props.data)
    return <div>


	<div className="section">

		<div className="container">

			<div className="row">

				<div className="col-md-5 col-md-push-2">
					<div id="product-main-img">
						<div className="product-preview">
                            <img src="./img/product01.png" alt=""></img>
						</div>

						<div className="product-preview">
                            <img src="./img/product03.png" alt=""></img>
						</div>

						<div className="product-preview">
                            <img src="./img/product06.png" alt=""></img>
						</div>

						<div className="product-preview">
                            <img src="./img/product08.png" alt=""></img>
						</div>
					</div>
				</div>

				<div className="col-md-2  col-md-pull-5">
					<div id="product-imgs">
						<div className="product-preview">
                            <img src="./img/product01.png" alt=""></img>
						</div>

						<div className="product-preview">
                            <img src="./img/product03.png" alt=""></img>
						</div>

						<div className="product-preview">
                            <img src="./img/product06.png" alt=""></img>
						</div>

						<div className="product-preview">
                            <img src="./img/product08.png" alt=""></img>
						</div>
					</div>
				</div>
				<div className="col-md-5">
					<div className="product-details">
						{props.data?<h2 className="product-name">{props.data.name}</h2>:(false)}

						{/*<div>*/}
							{/*<div className="product-rating">*/}
								{/*<i className="fa fa-star"></i>*/}
								{/*<i className="fa fa-star"></i>*/}
								{/*<i className="fa fa-star"></i>*/}
								{/*<i className="fa fa-star"></i>*/}
								{/*<i className="fa fa-star-o"></i>*/}
							{/*</div>*/}
							{/*<a className="review-link" href="#">10 Review(s) | Add your review</a>*/}
						{/*</div>*/}
						<div>
							{props.data?<h3 className="product-price">{props.data.price} грн</h3>:(false)}


						</div>
						{props.data?<h3 className="product-price"><p>{props.data.shortDescriprion}</p></h3>:(false)}




						<div className="add-to-cart">

							<button className="add-to-cart-btn"><i className="fa fa-shopping-cart"></i> add to cart
							</button>
						</div>

						<ul className="product-btns">
							<li><a href="#"><i className="fa fa-heart-o"></i> add to wishlist</a></li>

						</ul>

						{/*<ul className="product-links">*/}
							{/*<li>Category:</li>*/}
							{/*<li><a href="#">*</a></li>*/}
							{/*<li><a href="#">*</a></li>*/}
						{/*</ul>*/}



					</div>
				</div>



			</div>

		</div>

	</div>
    </div>
}
export default Product;