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
    valorTaxaEntrega !: number;
    instrucoesRetirada !: string;
    adicionarValor !:boolean;
    infoRetirada !:string;


    private _taxaEntrega !: number;
    public get taxaEntrega() : number {
      return this._taxaEntrega;
    }
    public set taxaEntrega(v : number) {
      this._taxaEntrega = v;
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
