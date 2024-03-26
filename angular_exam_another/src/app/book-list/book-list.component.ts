import { Component, EventEmitter, Input, Output } from '@angular/core';
import { Book } from '../models/Book';
import { NgFor } from '@angular/common';

@Component({
  selector: 'app-book-list',
  standalone: true,
  imports: [NgFor],
  templateUrl: './book-list.component.html',
  styleUrl: './book-list.component.css'
})
export class BookListComponent {
  @Input() bookList:Book[];
  
  @Output() itemSelected = new EventEmitter<Book>();

  public itemClicked(item:Book) {
    this.itemSelected.emit(item);
  }
}
