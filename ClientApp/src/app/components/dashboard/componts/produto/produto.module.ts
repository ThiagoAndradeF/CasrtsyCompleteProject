import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ProdutoComponent } from './produto.component';
import { RouterModule } from '@angular/router';
import { ButtonModule } from 'primeng/button';
import { TableModule } from 'primeng/table';
import { DialogModule } from 'primeng/dialog';
import { FormsModule } from '@angular/forms';
import { CriarProdutoComponent } from './components/criar-produto/criar-produto.component';
import { FileUploadModule } from 'primeng/fileupload';


@NgModule({
  declarations: [ProdutoComponent, CriarProdutoComponent],
  imports: [
    CommonModule,
    RouterModule.forChild([{ path: '', component: ProdutoComponent }]),
    ButtonModule,
    TableModule,
    DialogModule,
    FormsModule,
    FileUploadModule
  ]
})
export class ProdutoModule { }
