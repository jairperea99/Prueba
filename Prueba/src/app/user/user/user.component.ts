import { Component, ViewChild } from '@angular/core';
import { MatButtonModule } from '@angular/material/button';
import { MatPaginator } from '@angular/material/paginator';
import { MatTableDataSource, MatTableModule } from '@angular/material/table';
import { UsuariosService } from '../../services/usuarios.service';
import { HttpClientModule } from '@angular/common/http';
import { CommonModule } from '@angular/common';

export interface usuarios{
  id:number,
  nombre:string,
  apellido:string
}


const ELEMENT_DATA:usuarios[]=[
  {id:1,nombre:'Jair',apellido:'Perea'},
  {id:2,nombre:'Luis',apellido:'Perea'},
  {id:3,nombre:'Luisja',apellido:'Perea'}
]
@Component({
  selector: 'app-user',
  standalone: true,
  imports: [MatTableModule,MatButtonModule,HttpClientModule,CommonModule],
  templateUrl: './user.component.html',
  styleUrl: './user.component.css',
  
})
export class UserComponent {
  User:any[]=[];
  ocultar=true;
  constructor(
        private userService:UsuariosService
    ) {
   
   }
  displayedColumn:string[]=['id','nombre','apellido'];
  dataSource=new MatTableDataSource;
  ngOnInit():void {
  this.getUsers();

  }
  mostrar(){
    this.ocultar=false;
  }
  getUsers(){

    this.userService.getUsers().subscribe({
      next:(data:any)=>{
        this.dataSource=data;
        this.User=data;
      console.log(data);
      },error:(err:any)=>{
      console.log(err)
      }
    })
  }
 
}
