import React, { Component } from 'react';
import './style.css'
import axios from 'axios';
class Register extends Component{
         state={
            firstName:"",
            lastName:"",
            userName:" ",
             email  :" ",
            password: " ",
            gender: " "

                      
    }

    handleFirstNameChange= async (event)=>{
this.setState({
    firstName: await event.target.value
})
    }
handleLastNameChange= async(event)=>{
    this.setState({
        lastName: await event.target.value
    })
    }
    handleUserNameChange=async(event)=>{
        this.setState({
            userName: await event.target.value
        })
    } 
        handleEmailChange=async(event)=>{
            this.setState({
                email :await event.target.value
            })
        } 
            handlePasswordChange=async(event)=>{
                this.setState({
                    password: await event.target.value
                })
            } 
                handleGender= async (event)=>{
                    this.setState({
                     gender: await event.target.value
                    })
                }

handleSubmitButton =(e )=>{
    e.preventDefault();
    const user={
        firstName: this.state.firstName,
        LastName: this.state.lastName,
        UserName: this.state.userName,
        Email:this.state.email,
        Password: this.state.password,
        Gender: this.state.gender 
    };
    console.log(this.state.firstName);
    
axios.post('https://localhost:44346/api/Employee/AddEmployee',{ user })
.then( res=>{
    console.log(res);
    console.log(res.data);

  } )
}
    render(){
    
        return(
           <div className="main-div">
           <div className="Loginhr"><hr/>
             <div className="Login-div">Register User</div><hr className="hrid"/>
             </div>
               <div className="main-test-div">
                   <div className="fname-div">
                      <input type="text" className="input-fname-div" placeholder="FirstName" onChange={this.handleFirstNameChange} />
                   </div>
                   <div className="lname-div">
                      <input type="text" className="input-lname-div" placeholder="LastName" onChange={this.handleLastNameChange} />
                   </div>
                   <div className="uname-div">
                      <input type="text" className="input-uname-div" placeholder="UserName" onChange={this.handleUserNameChange} />
                   </div>
                   <div className="email-div">
                      <input type="text" className="input-email-div" placeholder="Email" onChange={this.handleEmailChange} />
                   </div>
                   <div className="password-div">
                      <input type="password" className="input-password-div" placeholder="Password" onChange={this.handlePasswordChange} />
                   </div>

                   <div className="gender-div">
                   <input type="text" className="input-gender-div" placeholder="Gender" onChange={this.handleGender} />
                </div>
                  
              </div>
               <div>
                <button className="submit" onClick={this.handleSubmitButton}>Submit</button>
               </div>
          </div>
        )
    }
}


export default Register
