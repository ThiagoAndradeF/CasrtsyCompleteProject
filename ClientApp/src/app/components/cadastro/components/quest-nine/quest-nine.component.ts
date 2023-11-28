import { Component, EventEmitter, Output } from '@angular/core';

@Component({
  selector: 'app-quest-nine',
  templateUrl: './quest-nine.component.html',
  styleUrls: ['./quest-nine.component.scss']
})
export class QuestNineComponent {
    @Output() emailLoja = new EventEmitter<string>();
    @Output() senhaLoja = new EventEmitter<string>();

    private _validadeEmail : boolean = false;
    public get validadeEmail() : boolean {
      return this._validadeEmail;
    }
    public set validadeEmail(v : boolean) {
      this._validadeEmail = v;
      this.emitValue(this.mailLoja);
    }

    private _mailLoja !: string;
    public get mailLoja() : string {
        return this._mailLoja;
    }
    public set mailLoja(v : string) {
        this._mailLoja = v;
        if(v){
            this.validarEmail(v);

        }

    }



    private _Password !: string;
    public get Password() : string {
      return this._Password;
    }
    public set Password(v : string) {
      this._Password = v;
      this.emitPassword(this.Password);
    }

    validarEmail(email: string) {
    // Usa uma expressão regular para validar o formato do e-mail
        const regex = /^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$/;
        if ( regex.test(email)) {
            this.validadeEmail=true

        } else {
            this.validadeEmail=false
        }
    }
    public emitValue(v:string) {
      this.emailLoja.emit(v);
    }
    public emitPassword(v:string){
      this.senhaLoja.emit(v);
    }






}
