import React from 'react';
import shop1 from '../static/img/len.jpg'
import shop2 from '../static/img/iphone.jpg'
import shop3 from '../static/img/comp.jpg'

const Home = () =>{
    return <div className="section">

		<div className="container">

			<div className="row">

				<div className="col-md-4 col-xs-6">
					<div className="shop">
						<div className="shop-img">
							<img src={shop1} alt=""></img>

						</div>
						<div className="shop-body">
							<h3>Laptop<br></br>Collection</h3>
							<a href="/category/1" className="cta-btn">Shop now <i className="fa fa-arrow-circle-right"></i></a>
						</div>
					</div>
				</div>



				<div className="col-md-4 col-xs-6">
					<div className="shop">
						<div className="shop-img">
							<img src={shop2} alt=""></img>
						</div>
						<div className="shop-body">
							<h3>Smartphones<br></br>Collection</h3>
							<a href="/category/2" className="cta-btn">Shop now <i className="fa fa-arrow-circle-right"></i></a>
						</div>
					</div>
				</div>

				<div className="col-md-4 col-xs-6">
					<div className="shop">
						<div className="shop-img">
							<img src={shop3} alt=""></img>
						</div>
						<div className="shop-body">
							<h3>Computers<br></br>Collection</h3>
							<a href="/category/3" className="cta-btn">Shop now <i className="fa fa-arrow-circle-right"></i></a>
						</div>
					</div>
				</div>

			</div>

		</div>

	</div>
}

export default Home;