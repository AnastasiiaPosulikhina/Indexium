import { Component } from '@angular/core';

@Component({
  selector: 'app-counter-component',
  templateUrl: './methodology.component.html'
})
export class CounterComponent {
  public currentCount = 0;

  public incrementCounter() {
    this.currentCount++;
  }
}
