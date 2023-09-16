import { Component, ElementRef, ViewChild } from '@angular/core';
import {FormControl} from '@angular/forms';
import { Produto } from 'src/app/plataforma-cliente/components/catalogo/models/item-catalogo.model'
@Component({
  selector: 'app-edit-card-dialog',
  templateUrl: './edit-card-dialog.component.html',
  styleUrls: ['./edit-card-dialog.component.scss']
})
export class EditCardDialogComponent {
  
  itenCard?: Produto;
  selectedImage: string | null = null;
  itenName?:string = '' ;
  itenPrice?:string = ''; 
  panelOpenState: boolean = false;  
  toppings = new FormControl('');
  
  @ViewChild('fileInput') fileInput!: ElementRef;


  onFileSelected(event: any) {
    const selectedFile = event.target.files[0];

    if (selectedFile && selectedFile.type.startsWith('image/')) {
      this.selectedImage = URL.createObjectURL(selectedFile);
    } else {
      this.selectedImage = null;
    }
  }

  exportImage() {
    if (this.selectedImage) {
      const canvas = document.createElement('canvas');
      const ctx = canvas.getContext('2d');
      const img = new Image();

      img.onload = () => {
        canvas.width = img.width;
        canvas.height = img.height;
        if(ctx)
        ctx.drawImage(img, 0, 0);
        // Exportar a imagem como Blob
        canvas.toBlob((blob) => {
          const a = document.createElement('a');
          if(blob)
          a.href = URL.createObjectURL(blob);
          a.download = 'imagem.png';
          a.click();
        }, 'image/png');
      };
      img.src = this.selectedImage;
    }
  }

  atribuirValor( idInput:string ) {
    const inputElement = document.getElementById(idInput) as HTMLInputElement;
    if (inputElement) {
      const _inputValue: string = inputElement.value;
      return _inputValue;
    }
    return 
  }


  salvarCard(){
    this.itenName = this.atribuirValor("itenName");
    this.itenPrice = this.atribuirValor("itenPrice");
    this.itenCard = new Produto(this.itenName, this.itenPrice, this.selectedImage)
    console.log(this.itenCard)
  }
 
  
}
