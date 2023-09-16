export class Produto{
    public nome? : string;
    public preco? : string;
    public image?: any;
    public descricao? : string; 

    constructor(valor1?: string, valor2?: string, valor3?:any ,valor4?:string ) {
        this.nome = valor1;
        this.preco = valor2;
        this.image = valor3;
        this.descricao = valor4;
      }
}

