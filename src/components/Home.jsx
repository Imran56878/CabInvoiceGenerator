import React, { Component } from "react";
import EmployeeData from "./EmployeeData";
import Register from "./Register";
import {BrowserRouter as Router,Route, Link} from 'react-router-dom'

class Home extends Component{
constructor( ){
    super()
    this.state={
        Message : "Welcome in Home Page "   
    }
    
}
render(){
    return(
        <div className="main-home-div">
        <h1>{this.state.Message}</h1>
        <Router>      
      <ul>
      <li>
      <Link to="/">Home</Link>
   </li>
      <li>
      <Link to="/EmployeeData">EmployeeDetails</Link>
   </li>
   <li>
   <Link to="/Register">Register</Link>
</li>  
      </ul>
         <Route path='/' component={Home} exact/>
         <Route path='/EmployeeData' component={EmployeeData} exact/>
         <Route path='/Register' component={Register} exact/>
    </Router>

    </div>
        )
}

}
export default Home