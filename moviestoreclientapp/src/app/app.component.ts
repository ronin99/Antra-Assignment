import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'moviestoreclientapp';
  showTitle = false;
  studentName ="Ronin";
  employess=["Ronin","Max","Kevin","Tony"];
  stateAcc="IL";
  logMessage(){
    console.log("button is clicked");
  }
}
