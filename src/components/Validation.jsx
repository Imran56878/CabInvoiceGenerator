import React, { Component } from 'react';
import {Redirect} from 'react-router-dom';
import Home from './Home'
import EmployeeData from './EmployeeData'

class Validation extends Component{
    constructor(props){
        super(props)
        this.state ={
            message:' ',
            email: this.props.email,
            password: this.props.password,
            test: false
        }
    }
    handleLoginMessage=()=>{
        if(this.props.email === "mi056878@gmail.com")
        {
            console.log("Correct email");
            if(this.props.password==="Imr@12345"){
              console.log("Correct password");
            }
            
            else {
                    {this.setState({message:"wrong password"})}
                 }
            }
        else{
            this.setState({
                message :"wrong email " });

        }
        

 }
 render(){
     return(
      <div className="main-validation-div">
      <h1>{this.state.email}</h1>
      <button className="submit" onClick={this.handleLoginMessage}>Submit</button>
      </div>
     )
 }
}

export default Validation