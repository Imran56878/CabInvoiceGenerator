import React, { Component } from 'react';
import './style.css'
import Validation from './Validation';
class LoginTest extends Component{
    constructor(props){
        super(props)
        this.state={
            email:"",
            password:""
        }
    }
    handleEmailChange= async (event)=>{
const email= await event.target.value;
this.setState({
    email:email
})
console.log("email",this.state.email);
    }
handlePasswordChange= async (event)=>{
    const password = await event.target.value;
    this.setState({
        password:password
    })
    console.log("password",this.state.password)
    
}
handleSubmitButton =()=>{
    var data={
        FirstName:  this.state.FirstName,
        
    }
    console.log(data)
    console.log("status",this.state.email,this.state.password);
}
    render(){
        return(
           <div className="main-div">
           <div className="Loginhr"><hr/>
             <div className="Login-div">Login</div><hr className="hrid"/>
             </div>
               <div className="main-test-div">
                   <div className="email-div">
                      <input type="email" className="input-email-div" placeholder="Email" onChange={this.handleEmailChange} />
                   </div>
                   <div className="password-div">
                   <input type="password" className="input-password-div" placeholder="Password" onChange={this.handlePasswordChange} />
                   </div>
              </div>
               <div>
                <Validation email={this.state.email} password={this.state.password} />
               </div>
          </div>
        )
    }
    
}
export default LoginTest