import { Component, EventEmitter, Output } from '@angular/core';

@Component({
  selector: 'app-quest-five',
  templateUrl: './quest-five.component.html',
  styleUrls: ['./quest-five.component.scss']
})
export class QuestFiveComponent {
    @Output() precoDoProduto = new EventEmitter<number>()

    private _precoProduto !: number;
    public get precoProduto() : number {
      return this._precoProduto;
    }
    public set precoProduto(v : number) {
      this._precoProduto = v;
      this.emitValue(v)
    }
    
    public emitValue(v:number) {
      this.precoDoProduto.emit(v);
    }




}
