import { Component, EventEmitter, Output } from '@angular/core';

@Component({
  selector: 'app-quest-one',
  templateUrl: './quest-one.component.html',
  styleUrls: ['./quest-one.component.scss']
})
export class QuestOneComponent {

    @Output() nomeDaLoja = new EventEmitter<string>();

    private _nomeLoja !: string;
    public get nomeLoja() : string {
      return this._nomeLoja;
    }
    public set nomeLoja(v : string) {
      this.emitValue(v)
      this._nomeLoja = v;
    }

    emitValue(v:string) {
      this.nomeDaLoja.emit(v);
    }




}
