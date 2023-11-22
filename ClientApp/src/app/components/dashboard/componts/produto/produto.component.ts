import { Component } from '@angular/core';
import { Product } from 'src/app/aplication/api/product';
// import { ProductService } from 'src/app/aplication/service/product.service';
import { StoreService } from '../../shared/store.service';
import { ItemDto } from '../../models/ItemDto';
import { ConfirmationService, MessageService } from 'primeng/api';

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
  dialogNovoProduto: boolean = false;
  displayAddDialog: boolean = false;
  newProduct: any = { name: '', price: '', stock: '' };
  storeId:number = 0;


  constructor( private storeService:StoreService, private confirmationService:ConfirmationService, private messageService: MessageService) {
     this.listarProdutos();
  }

  ngOnInit() {
    this.listarProdutos();
  }

  public listarProdutos(){
    this.storeService.getStoreWithItemsFirstLogin().subscribe(data => {
      if(data.items){
        this.items = data.items;
      }if(data.id)
      {this.storeId= data.id;}
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

  public showDialogAdicionarProduto(){
    this.dialogNovoProduto = true;
  }
  showAddNewDialog() {
    this.newProduct = { name: '', price: '', stock: '' }; // Reset do produto
    this.displayAddDialog = true; // Mostrar o dialog
  }
 
  addNewProduct() {
    this.storeService.addItemsToStoreById(this.storeId, this.newProduct).subscribe(data => {
      if(data){
        console.warn('Produto adicionado!')
      }
    });;
    this.items.push(this.newProduct); // Adicionar o novo produto à lista
    this.displayAddDialog = false; // Fechar o dialog após adicionar
  }
  deleteProduct(iten: ItemDto) {
    this.confirmationService.confirm({
        message: 'Tem certeza que quer deletar o item: ' + iten.name + '?',
        header: 'Confirmar',
        icon: 'pi pi-exclamation-triangle',
        accept: () => {
          if(iten.id){
            this.storeService.removeItemById(this.storeId, iten.id).subscribe()
          }
        }
    });}
}
