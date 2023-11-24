import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ProdutoComponent } from './produto.component';
import { RouterModule } from '@angular/router';
import { ButtonModule } from 'primeng/button';
import { TableModule } from 'primeng/table';
import { DialogModule } from 'primeng/dialog';
import { FormsModule } from '@angular/forms';
import { FileUploadModule } from 'primeng/fileupload';
import { ConfirmationService, MessageService } from 'primeng/api';
import { MultiSelectModule } from 'primeng/multiselect';


@NgModule({
  declarations: [ProdutoComponent],
  imports: [
    CommonModule,
    RouterModule.forChild([{ path: '', component: ProdutoComponent }]),
    ButtonModule,
    TableModule,
    DialogModule,
    FormsModule,
    FileUploadModule,
    MultiSelectModule
  ],
  providers:[
    ConfirmationService,
    MessageService
  ]
})
export class ProdutoModule { }
