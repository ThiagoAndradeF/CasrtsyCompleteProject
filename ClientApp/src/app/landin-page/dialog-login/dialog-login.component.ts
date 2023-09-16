import { Component, Inject } from '@angular/core';
import { MAT_DIALOG_DATA} from '@angular/material/dialog';
import { Router } from '@angular/router';
import { MatDialogRef } from '@angular/material/dialog';
export interface DialogData {
  animal: 'panda' | 'unicorn' | 'lion';
}
 
@Component({
  selector: 'app-dialog-login',
  templateUrl: './dialog-login.component.html',
  styleUrls: ['./dialog-login.component.scss']
})


export class DialogLoginComponent {
  constructor(
    @Inject(MAT_DIALOG_DATA) public data: DialogData,
    private dialogRef: MatDialogRef<DialogLoginComponent>,
    private router: Router
    
    ) {}
  public numeroEnviado : boolean = false;
  public codigoEnviado : boolean = false;
  enviarNumero(){
    this.numeroEnviado = true;
    
  }
  enviarCodigo(){
    this.codigoEnviado  = true; 
    this.dialogRef.close();
    this.router.navigate(['/plataforma']);
  }
  digits: string[] = ['', '', '', '','']; 
  
  onBackspace(index: number) {
    if (index > 0) {
      this.digits[index - 1] = '';
    }
  }
}
