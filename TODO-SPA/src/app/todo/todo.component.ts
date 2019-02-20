import { Component, OnInit } from '@angular/core';
import {TodoService} from '../service/todo.service';
import {NgForm, FormGroup, FormControl, Validators} from '@angular/forms';
import { Item } from '../model/item';

@Component({
  selector: 'app-todo',
  templateUrl: './todo.component.html',
  styleUrls: ['./todo.component.css'],
})
export class TodoComponent implements OnInit {
  model : Item;
  todoForm :FormGroup;
  items : Item[];
  constructor(private todoService: TodoService) { 
    this.model = new Item();
    this.todoForm = new FormGroup ({
      description: new FormControl ('',[Validators.required]),
      date : new FormControl ('', [Validators.required])
    });
    this.items = [];
  }

  ngOnInit() {
    this.getValues();
  }
  getValues() {
    this.todoService.getItems().subscribe(response => {
      this.items = response;
      this.sortArr();
    },error=>{
      console.log(error);
    });
  }
  
  sortArr(){
    console.log("sorting");
    this.items.sort((a,b) => {
      let arrA = a.date.split("-");
      let arrB = b.date.split("-");
      if (arrA[0] != arrB[0]){
        return +arrB[0] - +arrA[0];
      } else if (arrA[1] != arrB[1]){
        return +arrB[1] - +arrA[1];
      } else {
        return +arrB[2] - +arrA[2];
      }
    });
  }

  create(form: NgForm) {
    //console.log (this.model.date);
    this.todoService.postItem(this.model).subscribe(insertedItem => {
      this.items.push(insertedItem);
      this.resetForm(form);
      this.sortArr();
    });
  }

  resetForm(form: NgForm){
    form.reset();
    this.todoService.selectedItem = {
      id: null,
      description: '',
      date: null
    };
  }
  
  delete(id: number): void{
    this.todoService.deleteItem(id).subscribe(_ =>{
      this.items = this.items.filter(eachItem => eachItem.id !== id);
    });
  }

}
