import { Component } from '@angular/core'
import { MatDialog } from '@angular/material/dialog';
import { DialogLoginComponent } from './dialog-login/dialog-login.component';

@Component({
  selector: 'app-landin-page',
  templateUrl: './landin-page.component.html',
  styleUrls: ['./landin-page.component.scss']
})


export class LandinPageComponent {
  public logotipoPath: string = 'assets/cartsy.jpeg';
  public mainLogotipoPath: string = 'assets/logoPrinc.jpg';
  constructor(public dialog: MatDialog) {}
   
  openDialog() {
    this.dialog.open(DialogLoginComponent, {
      data: {
        animal: 'panda',
      },
    });
  }
  
}
