import { Component, EventEmitter, Output } from '@angular/core';

@Component({
  selector: 'app-quest-three',
  templateUrl: './quest-three.component.html',
  styleUrls: ['./quest-three.component.scss']
})
export class QuestThreeComponent {
    @Output() nmPrimeiroProduto = new EventEmitter<string>();


    private _nomePrimeiroProduto !: string;
    public get nomePrimeiroProduto() : string {
      return this._nomePrimeiroProduto;
    }
    public set nomePrimeiroProduto(v : string) {
      this._nomePrimeiroProduto = v;
    }

    public emitValue(v:string) {
      this.nmPrimeiroProduto.emit(v);
    }

}
