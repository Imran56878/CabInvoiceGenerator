import React, { Component } from 'react'
import './style.css'
import axios from 'axios';

export default class EmployeeData extends Component {
    constructor(props) {
        super(props)
        this.state = { employees: [] }

    }
    componentDidMount() {
        axios.get('https://localhost:44346/api/Employee/GetAllEmployee')
            .then(response => {
                this.setState({ employees: response.data });
                console.log(response.data);
            });
    }
    componentDidUpdate() {
        this.componentDidMount();

    }

    render() {
        const { employees, id, firstName, lastName } = this.state;
        return(
            <div className='main-table-div'>
                <div className='head-div'>
                    <h1 className='sentence2-div'>Employee Data</h1>
                </div>
                <table className="empTable" striped border hover size="sm" border="1">
                    <thead>
                        <tr>
                            <th>Id</th>
                            <th>FirstName</th>
                            <th>LastName</th>
                            <th>UsertName</th>
                            <th>Email</th>
                            <th>Password</th>
                            <th>Gender</th>
                        </tr>
                    </thead>
                    <tbody>
                        {this.state.employees.map(emp =>
                            <tr>
                                <td>{emp.id}</td>
                                <td>{emp.firstName}</td>
                                <td>{emp.lastName}</td>
                                <td>{emp.userName}</td>
                                <td>{emp.email}</td>
                                <td>{emp.password}</td>
                                <td>{emp.gender}</td>
                            </tr>
                        )}
                    </tbody>
                </table>

            </div>

        )
    }
}
