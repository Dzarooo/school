import { HttpClient, HttpClientModule } from '@angular/common/http';
import { Component, EventEmitter, Input, Output } from '@angular/core';
import { News } from '../models/News';
import { NgFor } from '@angular/common';

@Component({
  selector: 'app-news-list',
  standalone: true,
  imports: [HttpClientModule, NgFor],
  templateUrl: './news-list.component.html',
  styleUrl: './news-list.component.css'
})
export class NewsListComponent {
  url = "https://run.mocky.io/v3/93deb50f-6548-48e2-9da7-457b1a324a92";

  @Output() itemSelected = new EventEmitter<News>();

  @Input() newsList:News[] = [];

  itemClicked(item:News) {
    this.itemSelected.emit(item);
  }
}
