import { Component, Input } from '@angular/core';
import { Book } from '../models/Book';
import { NgIf } from '@angular/common';

@Component({
  selector: 'app-book-details',
  standalone: true,
  imports: [NgIf],
  templateUrl: './book-details.component.html',
  styleUrl: './book-details.component.css'
})
export class BookDetailsComponent {
  @Input() selectedBook:Book;
}
