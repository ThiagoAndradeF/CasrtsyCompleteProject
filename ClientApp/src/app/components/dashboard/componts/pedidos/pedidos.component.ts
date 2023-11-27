import { OrderDto } from './../../models/OrderDto';
import { Component } from '@angular/core';
import { StoreService } from '../../shared/store.service';
import { ItemDto } from '../../models/ItemDto';
import { AdditionalServiceDto } from '../../models/AdditionalServiceDto';
import { OrderFullDto } from '../../models/OrderFullDto';

@Component({
  selector: 'app-pedidos',
  templateUrl: './pedidos.component.html',
  styleUrls: ['./pedidos.component.scss']
})
export class PedidosComponent {

    private _orders : OrderFullDto[] = [];
    public get orders() : OrderFullDto[]  {
      return this._orders;
    }
    public set orders(v : OrderFullDto[] ) {
      this._orders = v;
      v.forEach(element => {
        console.warn('Pedidos: ' + element)
      });
    }


    validadePedido:boolean = false;
    pedidoFinalizado: boolean  = false;
    selectedOrder: OrderDto = new OrderDto();
    displayDialog: boolean = false;
    editedOrder:OrderDto = new OrderDto();
    dialogNewOrder: boolean = false;
    displayAddDialog: boolean = false;
    storeId:number = 0;

    private _nomeClienteNovoPedido !: string;
    public get nomeClienteNovoPedido() : string {
      return this._nomeClienteNovoPedido;
    }
    public set nomeClienteNovoPedido(v : string) {
      this._nomeClienteNovoPedido = v;
      this.newOrder.consumerName = v;
    }


    private _itensSelecionados : number[] = [];
    public get itensSelecionados() : number[] {
      return this._itensSelecionados;
    }
    public set itensSelecionados(v : number[]) {
      this._itensSelecionados = v;

    }

    private _newOrder : OrderDto= new OrderDto();
    public get newOrder() : OrderDto {
      return this._newOrder;
    }
    public set newOrder(v : OrderDto) {
      this._newOrder = v;
    }

    itensAvalible: ItemDto[] = [];

    additionalServicesAvalible: AdditionalServiceDto[] = [];

    constructor( private storeService:StoreService) {
    }

    ngOnInit() {
      this.listarProdutos();
      setTimeout(() => {
        this.listarServicos();
        this.listarOrders();
      }, 1000);
    }

    public atribuiValorNewOrder(){

    }
    public addNewOrder() {
      this.storeService.addOrderToStory(this.newOrder).subscribe(data => {
        if(data){
          console.log('Order adicionad!')
        }
      });
      setTimeout(() => {
        this.listarProdutos();
      }, 1000);
      this.displayAddDialog = false;
    }

    public listarOrders(){
      this.storeService.getAllOrders().subscribe(data => {
        if(data){
          debugger
          this.orders = data;
        }
      });
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


    public deleteOrder(order: OrderDto) {
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

    public validarPedido(){
      if(this.itensSelecionados.length>0 && this.nomeClienteNovoPedido){
        this.validadePedido = false;
      }else{
        this.validadePedido = true;
      }
    }

    public onDropdownChange(event: any) {
      console.log('Valores selecionados:', this.selectedOrder);
    }




}
