import { Component } from '@angular/core';
import { CadastroService } from './cadastro.service';

@Component({
  selector: 'app-cadastro',
  templateUrl: './cadastro.component.html',
  styleUrls: ['./cadastro.component.scss']
})
export class CadastroComponent {

  public desabAvancar:boolean = false;
  public desabRetroceder:boolean = true;
  public habilitaBotaoContinuar:boolean = true;
  public retirada!:boolean;
  public entrega!:boolean;
  public habEnvio: boolean =  false;





  private _mailLoja !: string;
  public get mailLoja() : string {
    return this._mailLoja;
  }
  public set mailLoja(v : string) {
    this._mailLoja = v;
    this.habEnvio= true;
    console.warn('O email da loja é  ' + v)
  }



  private _localRetirada !: string;
  public get localRetirada() : string {
    return this._localRetirada;
  }
  public set localRetirada(v : string) {
    this._localRetirada = v;
    console.warn('O endereço da loja é  ' + v)
  }



  private _valorEntrega : number = 0;
  public get valorEntrega() : number {
    return this._valorEntrega;
  }
  public set valorEntrega(v : number) {
    this._valorEntrega = v;
    console.warn('O valor de entrega é 0 ' + v)
  }

  private _precoProduto : number = 0;
  public get precoProduto() : number {
    return this._precoProduto;
  }
  public set precoProduto(v : number) {
    this._precoProduto = v;
    console.warn('O preco do primeiro produto é ' + v)
  }

  private _nmPrimeiroProduto !: string;
  public get nmPrimeiroProduto() : string {
    return this._nmPrimeiroProduto;
  }
  public set nmPrimeiroProduto(v : string) {
    this._nmPrimeiroProduto = v;
    console.warn('O nome do primeiro produto é ' + v)
  }

  private _tpProduto !: string ;
  public get tpProduto() : string {
    return this._tpProduto;
  }
  public set tpProduto(v : string) {
    this._tpProduto = v;
    console.warn('O produto selecionado foi ' + v)
  }


  private _nomeLoja !: string;
  public get nomeLoja() : string {
    return this._nomeLoja;
  }
  public set nomeLoja(v : string) {
    this._nomeLoja = v;
    console.warn('O nome da loja é ' + v)
  }

  private _metodoEntregaRecebido!: number;
  public get metodoEntregaRecebido() : number {

    return this._metodoEntregaRecebido;
  }
  public set metodoEntregaRecebido(v : number) {
    this._metodoEntregaRecebido = v;
    console.warn('O método de entrega selecionado foi ' + v)
    this.definirMetodoEntrega(v);
  }

  private _progresso : number = 10;
  public get progresso() : number {
    return this._progresso;
  }
  public set progresso(v : number) {
    this.desabAvancar = false;
    this.desabRetroceder = false;

    if(v >= 90 ){
        this.desabAvancar = true;
    }else if(v === 10){
        this.desabRetroceder = true;
    }
    this._progresso = v;
  }

  private _indexProgresso : number =1;
  public get indexProgresso() : number {
    return this._indexProgresso;
  }
  public set indexProgresso(v : number) {
    if(v === 3 || v === 1){
        this.habilitaBotaoContinuar = true;
    }else{
        this.habilitaBotaoContinuar = false;
    }
    this.progresso = (v * 10)
    this._indexProgresso = v;

  }

  constructor( private cadastroService: CadastroService ) {

      this.cadastroService.getSomeData().subscribe(data => {
        console.log('Dados recebidos:', data);
      });

   }

  public avancar(){
    this.indexProgresso <= 8 ? this.indexProgresso++ : this.indexProgresso = 9;
  }

  public retroceder(){
    this.indexProgresso > 1 ? this.indexProgresso-- : this.indexProgresso = 1;
  }
  public definirMetodoEntrega( param:number){
        switch(param){
            case 1:
                this.retirada = false;
                this.entrega =  true;
                break;
            case 2:
                this.retirada = true;
                this.entrega =  false;
                break;
            case 3:
                this.retirada = true;
                this.entrega =  true;
                break;
        }
    }

  public receberOutput(value: any , tipoOutput:number) {
      switch(tipoOutput){
        case 1:
          this.nomeLoja = value;
          break;
        case 2:
          console.warn("deu boa porra")
          this.tpProduto = value;

          break;
        case 3:
          this.nmPrimeiroProduto = value
          break;
        case 4:

          break;
        case 5:
          this.precoProduto = value
          break;
        case 6:
          break;
        case 7:
          this.metodoEntregaRecebido = value;
          break;
        case 8:
          if(typeof value === 'number')
            this.valorEntrega = value
          else{
            this.localRetirada = value
          }
          break;
        case 9:
          this.mailLoja = value
          break;

      }
    }



}
