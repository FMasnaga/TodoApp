import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {HttpClientModule} from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { TodoComponent } from './todo/todo.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { TodoService } from './service/todo.service';
import { TodoDetailComponent } from './todo-detail/todo-detail.component';


@NgModule({
   declarations: [
      AppComponent,
      TodoComponent,
      TodoDetailComponent,
   ],
   imports: [
      BrowserModule,
      AppRoutingModule,
      HttpClientModule,
      FormsModule,
      ReactiveFormsModule
   ],
   providers: [TodoService],
   bootstrap: [
      AppComponent
   ]
})
export class AppModule { }
