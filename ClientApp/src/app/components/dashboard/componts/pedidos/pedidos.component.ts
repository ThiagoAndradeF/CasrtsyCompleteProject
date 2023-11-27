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


    validadePedido:boolean = true;
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
      this.newOrder.consumerName;
      this.validarPedido();

    }


    private _itensSelecionados : number[] = [];
    public get itensSelecionados() : number[] {
      return this._itensSelecionados;
    }
    public set itensSelecionados(v : number[]) {
      this._itensSelecionados = v;
      this.validarPedido();

    }


    private _newOrder : OrderDto= new OrderDto();
    public get newOrder() : OrderDto {
      return this._newOrder;
    }
    public set newOrder(v : OrderDto) {
      this._newOrder = v;
    }

    itensAvalible: ItemDto[] = [];
    private _selectedItens : ItemDto[] = [] ;
    public get selectedItens() : ItemDto[]  {
      return this._selectedItens;
    }
    public set selectedItens(v : ItemDto[]) {
      this._selectedItens = v;
      this.calculateProductValue( v, this.additionalServicesSelected)
      this.selectedItens.forEach(element => {
          this.newOrder.itemIds.push(element.id)
      });

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
