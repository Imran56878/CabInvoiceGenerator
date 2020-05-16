import React, { Component } from 'react';
import './App.css';
import EmployeeData from './components/EmployeeData.jsx'
import Register from './components/Register.jsx'
import DeleteEmployee from './components/DeleteEmployee.jsx'
import {BrowserRouter as Router,Route, Link} from 'react-router-dom'
import LoginTest from './components/LoginTest.jsx';

class App extends Component{
  constructor(props){
    super(props)
  }
render(){
  return(
    <Router>      
    <ul>
    <li>
    <Link to="/LoginTest">Login</Link>
 </li>
    <li>
    <Link to="/">EmployeeDetails</Link>
 </li>
 <li>
 <Link to="/Register">Register</Link>
</li>  
<li>
 <Link to="/DeleteEmployee">Delete</Link>
</li>  
    </ul>
       <Route path='/LoginTest' component={LoginTest} exact/>
       <Route path='/' component={EmployeeData} exact/>
       <Route path='/Register' component={Register} exact/>
       <Route path='/DeleteEmployee' component={DeleteEmployee} exact/>
  </Router>

  )
}

}


export default App;
