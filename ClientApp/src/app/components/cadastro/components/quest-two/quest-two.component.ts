import { Component, EventEmitter, Output } from '@angular/core';

@Component({
  selector: 'app-quest-two',
  templateUrl: './quest-two.component.html',
  styleUrls: ['./quest-two.component.scss']
})
export class QuestTwoComponent {
    @Output() tpProdutoSelecionado = new EventEmitter<string>();

    private _tipoProduto !: string;
    public get tipoProduto() : string {
      return this._tipoProduto;
    }
    public set tipoProduto(v : string) {
      this._tipoProduto = v;
      this.emitValue(v)
    }

    public produtosDisponiveis?: string[] = [
    'Alimentos e Bebidas',
    'Artesanato',
    'Vestuário e Acessórios',
    'Beleza e Cuidados Pessoais',
    'Outro' ];

    public emitValue(v:string) {
      this.tpProdutoSelecionado.emit(v);
    }




}
