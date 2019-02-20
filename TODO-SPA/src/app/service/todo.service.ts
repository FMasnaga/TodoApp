import { Injectable } from '@angular/core';
import { Item } from '../model/item';
import {HttpClient} from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class TodoService {
  selectedItem: Item;
  values: any;
  url: string; 
    constructor(private http: HttpClient) { 
      this.url = 'http://localhost:5000/api/todos/';
    }

    postItem(model : Item) : Observable<Item> {
      //var body = JSON.stringify(model);
      //var headerOption = new Headers({'Content-Type' : 'application/json'});
      //var requestOption = new RequestOptions({method: RequestMethod.Post, headers: headerOption});
      return this.http.post<Item>(this.url,model);
    }

    getItems() : Observable<Item[]>{
      return this.http.get<Item[]>(this.url);
    }

    getItemFromId(id : number) : Observable<Item> {
      return this.http.get<Item>(this.url+id);
    }
    
    deleteItem(id : number):Observable<Item> {
      return this.http.delete<Item>(this.url+id);
    }
    

    updateItem(item : Item):Observable<Item>{
      return this.http.put<Item>(this.url+item.id, item);
    }
    


}


