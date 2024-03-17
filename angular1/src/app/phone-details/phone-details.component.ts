import { Component, Input, OnInit } from '@angular/core';
import { Phone } from '../models/Phone';
import { NgIf } from '@angular/common';

@Component({
  selector: 'app-phone-details',
  standalone: true,
  imports: [NgIf],
  templateUrl: './phone-details.component.html',
  styleUrl: './phone-details.component.css'
})
export class PhoneDetailsComponent {

  ngOnInit() {};
  @Input() activePhone: Phone;

}
