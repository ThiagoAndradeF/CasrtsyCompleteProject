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
    //RESULTADO DE GETS
    public desabilitarSalvamento: boolean = true;
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
    itensAvalible: ItemDto[] = [];
    additionalServicesAvalible: AdditionalServiceDto[] = [];
    storeId:number = 0;

    //DIALOG ADD PEDIDO
    _displayAddDialog: boolean = false;


    //DIALOG VER PEDIDO
    _displayInfoDialog:boolean = false;
    _orderInfo:OrderFullDto = new OrderFullDto();

    //NOVO ORDER CRIADA
    private _newOrder : OrderDto= new OrderDto();
    public get newOrder() : OrderDto {
      return this._newOrder;
    }
    public set newOrder(v : OrderDto) {
      this._newOrder = v;
    }

    private _nomeClienteNovoPedido !: string;
    public get nomeClienteNovoPedido() : string {
      return this._nomeClienteNovoPedido;
    }
    public set nomeClienteNovoPedido(v : string) {
      this._nomeClienteNovoPedido = v;
      this.newOrder.consumerName = v;
      this.verificarSePodeSalvar(v, this.itensSelecionados)
    }

    private _itensSelecionados : ItemDto[] = [];
    public get itensSelecionados() : ItemDto[] {
      return this._itensSelecionados;
    }
    public set itensSelecionados(v : ItemDto[]) {
      this._itensSelecionados = v;
      this.adicionarProdutosNewOrder();
      this.setarValoresPedidos(this.itensSelecionados, this.servicosSelecionados)
      this.verificarSePodeSalvar(this.nomeClienteNovoPedido, v)
    }

    private _servicosSelecionados : AdditionalServiceDto[] = [];
    public get servicosSelecionados() : AdditionalServiceDto[] {
      return this._servicosSelecionados;
    }
    public set servicosSelecionados(v : AdditionalServiceDto[]) {
      this._servicosSelecionados = v;
      this.adicionarServicosNewOrder();
      this.setarValoresPedidos(this.itensSelecionados, this.servicosSelecionados)
    }



    constructor( private storeService:StoreService) {
    }

    ngOnInit() {
      this.listarProdutos();
      setTimeout(() => {
        this.listarServicos();
        this.listarOrders();
      }, 300);
    }



    //MÉTODOS NEW ORDER
    public verificarSePodeSalvar(consumerName:string,  itensSelecionados:ItemDto[]){
      let tamanhoArray = itensSelecionados.length
      if(consumerName){
        if(tamanhoArray > 0){
          this.desabilitarSalvamento = false
        }
      }
    }

    public adicionarProdutosNewOrder(){
      let arrayIds:number[] = []
      this.itensSelecionados.forEach(element => {
        arrayIds.push(element.id)
      });
      this.newOrder.itemIds = arrayIds;
    }
    public adicionarServicosNewOrder(){
      let arrayIds:number[] = []
      this.servicosSelecionados.forEach(element => {
        arrayIds.push(element.id)
      });
      this.newOrder.serviceIds = arrayIds;
    }

    public setarValoresPedidos(itens: ItemDto[], service: AdditionalServiceDto[]){
      let valorOrder = 0;
      itens.forEach(element => {
        valorOrder+=element.price;
      });
      service.forEach(element => {
        valorOrder+=element.price;
      });
      this.newOrder.price = valorOrder;
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
      this.storeService.addOrderToStory(this.newOrder).subscribe(data => {
        if(data){
          console.log('Order adicionada!')
        }
        this.listarOrders();
      });
      this._displayAddDialog = false;
    }



    //EVENTO DIALOG
    public showAddNewDialog() {
      this.newOrder = new OrderDto();
      this._displayAddDialog = true;
    }

    public showInfo(item: OrderFullDto){
      this._orderInfo = new OrderFullDto();
      this._displayInfoDialog = true;
      this._orderInfo = item;
    }



    //LISTAR ITENS , ORDERS E SERVIÇOS
    public listarOrders(){
      this.storeService.getAllOrders().subscribe(data => {
        if(data){
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


}
