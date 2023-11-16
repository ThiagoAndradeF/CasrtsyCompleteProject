import { Component } from '@angular/core';
import { Product } from 'src/app/aplication/api/product';
import { ProductService } from 'src/app/aplication/service/product.service';
import { StoreService } from '../../shared/store.service';
import { ItemDto } from '../../models/ItemDto';

@Component({
  selector: 'app-produto',
  templateUrl: './produto.component.html',
  styleUrls: ['./produto.component.scss'],

})
export class ProdutoComponent {
  items : ItemDto[] = [];
  selectedItem!: ItemDto;
  displayDialog: boolean = false;
  editedIten:ItemDto = new ItemDto();


  constructor(private productService: ProductService, private storeService:StoreService) {
     this.listarProdutos();
  }

  ngOnInit() {
    this.listarProdutos();
  }

  public listarProdutos(){
    this.storeService.getStoreWithItemsFirstLogin().subscribe(data => {
      if(data.items){
        this.items = data.items;
      }
    });
  }
  public showDialog(item: ItemDto) {
    this.selectedItem = item;
    this.displayDialog = true;
  }
  saveChanges() {

    if(this.selectedItem){


    this.displayDialog = false;
      const index = this.items.findIndex(i => i.id === this.selectedItem.id);
      if (index > -1) {
        if(this.editedIten.price){
          this.items[index].price = this.editedIten.price;
        }
        if(this.editedIten.name){
          this.items[index].name = this.editedIten.name;
        }
        if(this.editedIten.stock){
          this.items[index].stock = this.editedIten.stock;
        }
      }
    }
    this.displayDialog = false; // Fecha o dialog após salvar as alterações
    this.editedIten = new ItemDto();

  }
}