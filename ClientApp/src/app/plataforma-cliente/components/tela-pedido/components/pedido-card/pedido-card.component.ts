import { Component, HostListener, Inject, Input } from '@angular/core';
import { TpStatusPedido } from '../../tela-pedidos/shared/enums/tp-status.enum';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
// import { ProdutoModalComponent } from '@skychart/produto-modal';
import { PedidosService } from '../../tela-pedidos/shared/services/pedidos.service';
import { PedidoExtenso, Produto } from './models/pedido.model'
import { PedidoCardDialogComponent } from './pedido-card-dialog/pedido-card-dialog.component';
@Component({
  selector: 'app-pedido-card',
  templateUrl: './pedido-card.component.html',
  styleUrls: ['./pedido-card.component.css']
})
export class PedidoCardComponent {
  public dialogRef?:any;
  public idPortalRemoveMasterHouse: boolean = false;

  public  TpStatusPedido = TpStatusPedido;
  public readonly comboTpStatusFollowUp = [
    { label: 'A fazer', value: TpStatusPedido.A_FAZER, color: '#000' }
    , { label: 'Agendados', value: TpStatusPedido.AGENDADOS, color: '#000' }
    , { label: 'Entregues', value: TpStatusPedido.ENTREGUES, color: '#000' }
  ];

  private _card?: PedidoExtenso;
  @Input()
  public get card(): any { 
    if(this._card){
      return this._card;
    }
   }
  public set card(card: PedidoExtenso) {
    this._card = card;
  }

  constructor(
    @Inject(MatDialog)
    private matDialog: MatDialog
    , private pedidosService: PedidosService
    , public dialog: MatDialog,
  ) {

    // this.pedidosService.obterParametro('ID_PORTAL_REMOVE_MASTER_HOUSE').subscribe(ret => {
    //   this.idPortalRemoveMasterHouse = ret;
    // });
  }
  ngOnInit() {
  }

  @HostListener('click', ['event'])
  public openDialog() {
    const dialogConfig = new MatDialogConfig();
    dialogConfig.data = { idPedido: this.card.idPedido };
    this.dialog.open(PedidoCardDialogComponent, dialogConfig);
  }
}
