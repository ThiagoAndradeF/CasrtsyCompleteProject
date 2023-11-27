import { OrderDto } from './../../models/OrderDto';
import { Component } from '@angular/core';
import { StoreService } from '../../shared/store.service';
import { ItemDto } from '../../models/ItemDto';
import { AdditionalServiceDto } from '../../models/AdditionalServiceDto';

@Component({
  selector: 'app-pedidos',
  templateUrl: './pedidos.component.html',
  styleUrls: ['./pedidos.component.scss']
})
export class PedidosComponent {

    private _orders : OrderDto[] = [];
    public get orders() : OrderDto[]  {
      return this._orders;
    }
    public set orders(v : OrderDto[] ) {
      this._orders = v;
    }

    pedidoFinalizado: boolean  = false;
    selectedOrder: OrderDto = new OrderDto();
    displayDialog: boolean = false;
    editedOrder:OrderDto = new OrderDto();
    dialogNewOrder: boolean = false;
    displayAddDialog: boolean = false;
    newOrder: OrderDto = new OrderDto();
    storeId:number = 0;

    itensAvalible: ItemDto[] = [];
    private _selectedItens : ItemDto[] = [] ;
    public get selectedItens() : ItemDto[]  {
      return this._selectedItens;
    }
    public set selectedItens(v : ItemDto[]) {
      this.calculateProductValue( v, this.additionalServicesSelected)
      this._selectedItens = v;
    }

    additionalServicesAvalible: AdditionalServiceDto[] = [];
    private _additionalServicesSelected : AdditionalServiceDto[] = [];
    public get additionalServicesSelected() : AdditionalServiceDto[] {
      return this._additionalServicesSelected;
    }
    public set additionalServicesSelected(v : AdditionalServiceDto[]) {
      this.calculateProductValue(this.selectedItens, v)
      this._additionalServicesSelected = v;

    }

    constructor( private storeService:StoreService) {
    }

    ngOnInit() {
      this.listarServicos();
      this.listarProdutos();
    }

    public listarServicos(){
      this.storeService.getStoreWithServices().subscribe(data => {
        console.warn(data)
        if(data.services){
          this.additionalServicesAvalible = data.services;
        }
      });
    }
    public showDialogAdicionarServico(){
      this.dialogNewOrder = true;
    }

    public showAddNewDialog() {
      this.newOrder = new OrderDto();
      this.displayAddDialog = true;
      this.additionalServicesSelected = [];
      this.selectedItens = [];
    }

    public calculateProductValue(itens: ItemDto[], services: AdditionalServiceDto[]){
      this.newOrder.price= 0 ;
      itens.forEach(iten => {
        if(iten.price){
          this.newOrder.price+=iten.price;
        }
      });
      services.forEach(service => {
        if(service.price){
          this.newOrder.price+= service.price;
        }
      });
    }

    public addNewOrder() {
      // this.storeService.addServicesToStoreById(this.newOrder).subscribe(data => {
      //   if(data){
      //     console.log('Serviço adicionado!')
      //   }
      // });;
      this.orders.push(this.newOrder); // Adicionar o novo produto à lista
      this.displayAddDialog = false; // Fechar o dialog após adicionar
    }
    public deleteOrder(order: OrderDto) {
      // if(OrderDto.id){
      //   this.storeService.removeServiceById(OrderDto.id).subscribe();
      //   setTimeout(() => {
      //     this.listarServicos();
      //   }, 1000);
      // }
    }
    public listarProdutos(){
      this.storeService.getStoreWithItemsFirstLogin().subscribe(data => {
        if(data.items){
          this.itensAvalible = data.items;
        }if(data.id)
        {
          this.storeId= data.id;
          localStorage.setItem('idLoja', data.id.toString());
        }
      });
    }



    public onDropdownChange(event: any) {
      console.log('Valores selecionados:', this.selectedOrder);
    }
}
