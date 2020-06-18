import React from 'react';
import comp from '../static/img/comp.jpg'

const AllCategories = (props) =>{
    return <div>



		<div className="section">

			<div className="container">

				<div className="row">
					<h3 className="text-center">All Categories</h3>
					<div className="col-md-12" style={{marginTop:"50px"}}>
						{props.data? props.data.map((category)=> {
							return(
								<div className="col-md-4">
									<img src={comp} alt="" style={{height:"150px"}}/>
									<a href={'category/'+category.id}>
										{category.nameCategory}
									</a>
								</div>


							)
						}):(false)}
					</div>

			</div>

		</div>
    </div>
	</div>
}
export default AllCategories;