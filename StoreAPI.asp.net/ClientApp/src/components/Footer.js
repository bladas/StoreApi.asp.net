import React from 'react';


const Footer = () =>{
    return <footer id="footer">

		<div className="section">

			<div className="container">

				<div className="row">
					<div className="col-md-3 col-xs-6">
						<div className="footer">
							<h3 className="footer-title">About Us</h3>
							<p>Some info</p>
							<ul className="footer-links">
								<li><a href="#"><i className="fa fa-map-marker"></i>location</a></li>
								<li><a href="#"><i className="fa fa-phone"></i>+012-34-56-79</a></li>
								<li><a href="#"><i className="fa fa-envelope-o"></i>email@email.com</a></li>
							</ul>
						</div>
					</div>

					<div className="col-md-3 col-xs-6">
						<div className="footer">
							<h3 className="footer-title">Categories</h3>
							<ul className="footer-links">
								<li><a href="#">*</a></li>
								<li><a href="#">*</a></li>
								<li><a href="#">*</a></li>
								<li><a href="#">*</a></li>
								<li><a href="#">*</a></li>
							</ul>
						</div>
					</div>

					<div className="clearfix visible-xs"></div>

					<div className="col-md-3 col-xs-6">
						<div className="footer">
							<h3 className="footer-title">Information</h3>
							<ul className="footer-links">
								<li><a href="#">About Us</a></li>
								<li><a href="#">Contact Us</a></li>
								<li><a href="#">*</a></li>
								<li><a href="#">*</a></li>
								<li><a href="#">*</a></li>

							</ul>
						</div>
					</div>

					<div className="col-md-3 col-xs-6">
						<div className="footer">
							<h3 className="footer-title">Service</h3>
							<ul className="footer-links">
								<li><a href="#">My Account</a></li>
								<li><a href="#">View Cart</a></li>
								<li><a href="#">Wishlist</a></li>
								<li><a href="#">Track My Order</a></li>
								<li><a href="#">Help</a></li>
							</ul>
						</div>
					</div>
				</div>

			</div>

		</div>



		<div id="bottom-footer" className="section">
			<div className="container">

				<div className="row">
					<div className="col-md-12 text-center">

						<span className="copyright">

							Copyright &copy;
							<script>document.write(new Date().getFullYear());</script> All rights reserved | This template is made with <i
							className="fa fa-heart-o" aria-hidden="true"></i> by bladas <a href="https://github.com/bladas">Github</a>

							</span>
					</div>
				</div>

			</div>

		</div>

	</footer>
}

export default Footer;