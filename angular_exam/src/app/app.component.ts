import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { HeaderComponent } from './header/header.component';
import { FooterComponent } from './footer/footer.component';
import { NewsListComponent } from './news-list/news-list.component';
import { News } from './models/News';
import { NewsDetailsComponent } from './news-details/news-details.component';
import { HttpClient, HttpClientModule } from '@angular/common/http'; 

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, HeaderComponent, FooterComponent, NewsListComponent, NewsDetailsComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'angular_exam';
  url = "https://run.mocky.io/v3/93deb50f-6548-48e2-9da7-457b1a324a92";

  selectedItem:News;
  news:News[];

  constructor(public httpclient: HttpClient) {
    this.httpclient.get(this.url).subscribe((news: News[]) => {
      this.news = news['news'];
    })
  }
  
  onItemSelected(item) {
    this.selectedItem = item;
  }
}
