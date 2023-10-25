import { Component, EventEmitter, Output } from '@angular/core';

@Component({
  selector: 'app-quest-six',
  templateUrl: './quest-six.component.html',
  styleUrls: ['./quest-six.component.scss']
})
export class QuestSixComponent {
  @Output() ativarAgenda = new EventEmitter<boolean>();

  private _ativarAgendamento !: boolean;
  public get ativarAgendamento() : boolean {
    return this._ativarAgendamento;
  }
  public set ativarAgendamento(v : boolean) {
    this._ativarAgendamento = v;
    this.emitValue(v);
  }


  public onOffAgenda(param: boolean){
      if(param==true){
          this.ativarAgendamento=true
      }else{
          this.ativarAgendamento=false
      }
  }

  public emitValue(v:boolean) {
    this.ativarAgenda.emit(v);
  }


}
