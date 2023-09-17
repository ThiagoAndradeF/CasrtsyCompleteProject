import { Component } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { EditCardDialogComponent } from '../edit-card-dialog/edit-card-dialog.component';

@Component({
  selector: 'app-card-catalogo',
  templateUrl: './card-catalogo.component.html',
  styleUrls: ['./card-catalogo.component.scss']
})
export class CardCatalogoComponent {
  constructor(
    public  dialog: MatDialog) {}
  nortom(){
    console.log('neitinho píneiro')
  }
  openDialog() {
    this.dialog.open(EditCardDialogComponent);
  }

  
}
