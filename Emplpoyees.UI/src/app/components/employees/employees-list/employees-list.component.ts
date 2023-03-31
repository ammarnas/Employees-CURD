import { Component, OnInit } from '@angular/core';
import { Employee } from 'src/app/models/employee.model';

@Component({
  selector: 'app-employees-list',
  templateUrl: './employees-list.component.html',
  styleUrls: ['./employees-list.component.css']
})
export class EmployeesListComponent implements OnInit {
  
  employees: Employee[] = [
    {
      id: '1',
      name: 'qq',
      email: 'qqq',
      phone: 999999,
      salary: 9999,
      department: 'qqqq'
    },
    {
      id: '1',
      name: 'qq',
      email: 'qqq',
      phone: 999999,
      salary: 9999,
      department: 'qqqq'
    },
    {
      id: '1',
      name: 'qq',
      email: 'qqq',
      phone: 999999,
      salary: 9999,
      department: 'qqqq'
    },
    {
      id: '1',
      name: 'qq',
      email: 'qqq',
      phone: 999999,
      salary: 9999,
      department: 'qqqq'
    },
    {
      id: '1',
      name: 'qq',
      email: 'qqq',
      phone: 999999,
      salary: 9999,
      department: 'qqqq'
    },
    {
      id: '1',
      name: 'qq',
      email: 'qqq',
      phone: 999999,
      salary: 9999,
      department: 'qqqq'
    },
  ]
  ngOnInit(): void {
    throw new Error('Method not implemented.');
  }

}
