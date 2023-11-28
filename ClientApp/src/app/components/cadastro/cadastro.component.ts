import { Component } from '@angular/core';
import { CadastroService } from './cadastro.service';
import { StoreFormDto, ItemDto, AdditionalServiceDto, TypeDto } from './components/Models/store-form-dto';
import { LayoutService } from 'src/app/layout/service/app.layout.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-cadastro',
  templateUrl: './cadastro.component.html',
  styleUrls: ['./cadastro.component.scss']
})
export class CadastroComponent {
  public desabilitarSalvamento:boolean = true;
  public desabAvancar:boolean = false;
  public desabRetroceder:boolean = true;
  public habilitaBotaoContinuar:boolean = true;
  public retirada!:boolean;
  public entrega!:boolean;
  public habEnvio: boolean =  false;
  public storeFormForCreation : StoreFormDto = new StoreFormDto();

  private _Password !: string;
  public get Password() : string {
    return this._Password;
  }
  public set Password(v : string) {
    this._Password = v;
    this.storeFormForCreation.Password = v
    this.verificarSePodeSalvar( this.mailLoja, v)
  }


  private _mailLoja !: string;
  public get mailLoja() : string {
    return this._mailLoja;
  }


  private _agendamento !: boolean;
  public get agendamento() : boolean {
    return this._agendamento;

  }
  public set agendamento(v : boolean) {
    this._agendamento = v;
    this.avancar();
    console.warn('O agendamento é  ' + v)
  }



  public set mailLoja(v : string) {
    this._mailLoja = v;
    this.habEnvio= true;
    this.storeFormForCreation.Email = v;
    console.warn('O email da loja é  ' + v)
    this.verificarSePodeSalvar(v, this.Password)

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
    this.storeFormForCreation.Services = [new AdditionalServiceDto("Entrega Motoboy", v, "Entrega Tradicional")];
    if(this.valorEntrega === 0){
      this.avancar();
    }
    console.warn('O valor de entrega é 0 ' + v)
  }

  private _precoProduto : number = 0;
  public get precoProduto() : number {
    return this._precoProduto;
  }
  public set precoProduto(v : number) {
    this._precoProduto = v;
    this.storeFormForCreation.Items[0].price = v;
    console.warn('O preco do primeiro produto é ' + v)
  }

  private _nmPrimeiroProduto !: string;
  public get nmPrimeiroProduto() : string {
    return this._nmPrimeiroProduto;
  }
  public set nmPrimeiroProduto(v : string) {
    this._nmPrimeiroProduto = v;
    this.storeFormForCreation.Items[0].name = v;
    console.warn('O nome do primeiro produto é ' + v)
  }

  private _tpProduto !: string ;
  public get tpProduto() : string {
    return this._tpProduto;
  }
  public set tpProduto(v : string) {
    this._tpProduto = v;
    this.storeFormForCreation.Items[0].type = new TypeDto(v)
    this.avancar();
    console.warn('O produto selecionado foi ' + v)
  }

  private _nomeLoja !: string;
  public get nomeLoja() : string {
    return this._nomeLoja;
  }
  public set nomeLoja(v : string) {
    this._nomeLoja = v;
    this.storeFormForCreation.Name = v;
    console.warn('O nome da loja é ' + v)
  }

  private _metodoEntregaRecebido!: number;
  public get metodoEntregaRecebido() : number {

    return this._metodoEntregaRecebido;
  }
  public set metodoEntregaRecebido(v : number) {
    this._metodoEntregaRecebido = v;
    this.avancar();
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

  constructor( private cadastroService: CadastroService,  private router:Router  ) {}


  ngOnInit(){
    this.storeFormForCreation.Items = [new ItemDto()]
  }

  public assinarFormulario(){
    this.cadastroService.getSomeData(this.storeFormForCreation).subscribe(data => {
      if(data){
        console.warn('Usuário cadastrado!')
        localStorage.setItem('authToken','logado');
        setTimeout(() => {
          this.router.navigate(['']);
        }, 100);


      }
    });
  }
  public validarEmail(email: string) {
    // Usa uma expressão regular para validar o formato do e-mail
        const regex = /^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$/;
        if ( regex.test(email)) {
            return true

        } else {
            return false
        }

    }

  public verificarSePodeSalvar(email:string,  senha:string){
    let emailValido:boolean = this.validarEmail(email)
    if(emailValido){
      if(senha.length>5){
        this.desabilitarSalvamento = false
      }
      else{
        console.warn('A senha deve ter no minimo cinco digitos')
      }
    }
  }
  public popularForm(){

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
    public receberPassword(value: string) {
      this.Password = value;
    }

  public receberOutput(value: any , tipoOutput:number) {
      switch(tipoOutput){
        case 1:
          this.nomeLoja = value;
          break;
        case 2:
          this.tpProduto = value;

          break;
        case 3:
          this.nmPrimeiroProduto = value;
          break;
        case 4:

          break;
        case 5:
          this.precoProduto = value;
          break;
        case 6:
          this.agendamento = value;
          break;
        case 7:
          this.metodoEntregaRecebido = value;
          break;
        case 8:
          if(typeof value === 'number')
            this.valorEntrega = value;
          else{
            this.localRetirada = value;
          }
          break;
        case 9:
          this.mailLoja = value;
          break;

      }
    }



}
