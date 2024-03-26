import { HttpClient, HttpClientModule } from '@angular/common/http';
import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { Book } from './models/Book';
import { HeaderComponent } from './header/header.component';
import { BookListComponent } from './book-list/book-list.component';
import { BookDetailsComponent } from './book-details/book-details.component';
import { AdvertisementComponent } from './advertisement/advertisement.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, HttpClientModule, HeaderComponent, BookListComponent, BookDetailsComponent, AdvertisementComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})

export class AppComponent {
  title = 'angular_exam_another';

  url = "https://run.mocky.io/v3/d2802343-a2cb-4f3c-85da-525e57206045";

  bookList:Book[]
  selectedBook:Book;

  constructor(public httpclient: HttpClient) {
    this.httpclient.get(this.url).subscribe((bookList:Book[]) => {
      this.bookList = bookList;
      console.log(this.bookList);
    })
  }

  public onItemSelected(item:Book) {
    this.selectedBook = item;
    //console.log(this.selectedBook);
  }
}