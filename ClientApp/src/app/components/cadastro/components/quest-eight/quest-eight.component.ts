import { Component, EventEmitter, Input, Output } from '@angular/core';

@Component({
  selector: 'app-quest-eight',
  templateUrl: './quest-eight.component.html',
  styleUrls: ['./quest-eight.component.scss']
})
export class QuestEightComponent {
    @Output() valorEntrega = new EventEmitter<number>();
    @Output() localRetirada = new EventEmitter<string>();

    @Input() _entrega !: boolean;
    @Input() _retirada !: boolean ;
    public adicionarValor !:boolean;




    private _valorTaxaEntrega : number = 0;
    public get valorTaxaEntrega() : number {
      return this._valorTaxaEntrega;
    }
    public set valorTaxaEntrega(v : number) {
      this._valorTaxaEntrega = v;
      this.emitValue(v ,true)
    }




    private _infoRetirada !: string;
    public get infoRetirada() : string {
      return this._infoRetirada;
    }
    public set infoRetirada(v : string) {
      this._infoRetirada = v;
      this.emitValue(v ,false)
    }






    cobrarEntrega(value:number){
        switch(value){
            case 1:
                this.adicionarValor = true;
                break;
            case 2:
                this.adicionarValor = true;
                break;
            case 3:
                this.adicionarValor = false;
                this.valorTaxaEntrega = 0;
                break;
        }

    }
    public emitValue(v:any , paramEntrega: boolean) {
      if(paramEntrega){
        this.valorEntrega.emit(v);
      }else{
        this.localRetirada.emit(v)
      }
    }

}
