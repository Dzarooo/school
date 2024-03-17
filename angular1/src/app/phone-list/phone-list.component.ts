import { Component, EventEmitter, Output, OnInit } from '@angular/core';
import { NgFor } from '@angular/common';
import { Phone } from '../models/Phone';

@Component({
  selector: 'app-phone-list',
  standalone: true,
  imports: [NgFor],
  templateUrl: './phone-list.component.html',
  styleUrl: './phone-list.component.css'
})

export class PhoneListComponent {

  ngOnInit() {}

  @Output() phoneSelected = new EventEmitter<Phone>();

  phoneList: Phone[] = [
    new Phone(1, 'iPhone', '10', 1200),
    new Phone(2, 'iPhone', '13 Ultra', 2500),
    new Phone(3, 'Samsung', 'S23+', 3200),
    new Phone(4, 'No Phone', '2', 1800),
  ];

  public select(phone: Phone) {
    this.phoneSelected.emit(phone);
  }
}