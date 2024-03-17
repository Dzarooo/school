import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { PhoneListComponent } from './phone-list/phone-list.component';
import { Phone } from './models/Phone'
import { PhoneDetailsComponent } from './phone-details/phone-details.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, PhoneListComponent, PhoneDetailsComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'angular1';

  selectedPhone: Phone;

  onPhoneSelected(phone: Phone) {
    console.log(phone);
    this.selectedPhone = phone;
  }
}
