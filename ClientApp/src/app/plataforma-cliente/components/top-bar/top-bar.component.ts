import { Component } from '@angular/core';
@Component({
  selector: 'app-top-bar',
  templateUrl: './top-bar.component.html',
  styleUrls: ['./top-bar.component.scss']
})
export class TopBarComponent {
  constructor() { }
  
  public isMobile:boolean=true;
  recarregarPagina() {
    window.location.reload();
  }

}
