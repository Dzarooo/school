import { Component, Input } from '@angular/core';
import { News } from '../models/News';
import { NgIf } from '@angular/common';

@Component({
  selector: 'app-news-details',
  standalone: true,
  imports: [NgIf],
  templateUrl: './news-details.component.html',
  styleUrl: './news-details.component.css'
})
export class NewsDetailsComponent {
  @Input() activeItem: News;
}
