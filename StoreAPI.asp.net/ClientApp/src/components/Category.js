import React from 'react';
import shop1 from '../static/img/product01.png'
import comp from '../static/img/comp.jpg'
import phome from '../static/img/iphone.jpg'


const Category = (props) =>{
	if (props.data){console.log(props.data)}
	return <div>



		<div className="section">

			<div className="container">

				<div className="row">
					{props.data?
					<h3 className="text-center">{props.data.nameCategory}</h3>:(false)}

					{props.data?props.data.nameCategory == "Ноутбуки"? props.data.products.map((product)=> {
							return(<div>

								<div className="col-md-4" style={{marginTop:"50px"}}>

										<div className="col-md-12 text-center">
										<div className="col-md-12">
											<img style={{height:"150px"}} src={shop1} alt=""/>
											</div>

											<a href={'/product/'+product.id}>{product.name}</a>


										</div>
										<div className="col-md-12 text-center">
											<p >{product.price} грн</p>
										</div>

								</div>

						</div>
							)
						}):(false):false}
						{props.data?props.data.nameCategory == "Телефони"? props.data.products.map((product)=> {
							return(<div>

								<div className="col-md-4" style={{marginTop:"50px"}}>

										<div className="col-md-12 text-center">
										<div className="col-md-12">
											<img style={{height:"150px"}} src={phome} alt=""/>
											</div>

											<a href={'/product/'+product.id}>{product.name}</a>


										</div>
										<div className="col-md-12 text-center">
											<p >{product.price} грн</p>
										</div>

								</div>

						</div>
							)
						}):(false):false}
						{props.data?props.data.nameCategory == "Комп'ютери"? props.data.products.map((product)=> {
							return(<div>

								<div className="col-md-4" style={{marginTop:"50px"}}>

										<div className="col-md-12 text-center">
										<div className="col-md-12">
											<img style={{height:"150px"}} src={comp} alt=""/>
											</div>

											<a href={'/product/'+product.id}>{product.name}</a>


										</div>
										<div className="col-md-12 text-center">
											<p >{product.price} грн</p>
										</div>

								</div>

						</div>
							)
						}):(false):false}



			</div>

		</div>
    </div>
	</div>
}
export default Category;