import { Component, OnInit } from '@angular/core';
import { Item } from '../model/item';
import { TodoService } from '../service/todo.service';
import {Location} from '@angular/common';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-todo-detail',
  templateUrl: './todo-detail.component.html',
  styleUrls: ['./todo-detail.component.css']
})
export class TodoDetailComponent implements OnInit {
  item : Item;
  constructor(private service : TodoService, private location : Location, private route:ActivatedRoute ) { 
    this.item = new Item();
  }

  ngOnInit() {
    this.getItemFromRoute();
  }

  getItemFromRoute():void {
    const id = +this.route.snapshot.paramMap.get('id');
    this.service.getItemFromId(id).subscribe(result =>{
      this.item = result;
    });
  }

  update(): void {
    this.service.updateItem(this.item).subscribe(_ =>{
      this.goBack();
    });
  }

  goBack(){
    this.location.back();
  }

}
