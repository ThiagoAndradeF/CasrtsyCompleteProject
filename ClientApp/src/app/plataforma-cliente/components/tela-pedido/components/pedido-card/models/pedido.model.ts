
import { PedidosService } from '../../../tela-pedidos/shared/services/pedidos.service';


export class Pedido{ 
    public IdPedido?: number;
    public IdCliente?: number;
    public IdServicos?: number[];
    public IdProduto?: number;
    constructor(idProduto: number, idCliente: number, idServicos?:number[] ) {
        this.IdPedido = idProduto;
        this.IdCliente = idCliente;
        this.IdServicos = idServicos;
    }
}

export class Servico {
    IdServico?: number;
    NmServico?: string;
    PrecoServico?: number;
    constructor(idServico: number, nmServico: string, precoServico?:number ) {
        this.IdServico = idServico;
        this.NmServico = nmServico;
        this.PrecoServico = precoServico;
    }
}

export class Cliente{
    IdCliente?: number;
    NmCliente?: string;
    Fone?:string 
    IdEndereco?: number;
    constructor(idCliente: number, nmCliente: string, fone: string , idEndereco?: number) {
        this.IdCliente = idCliente;
        this.NmCliente = nmCliente;
        this.Fone = fone;
        this.IdEndereco = idEndereco;
    }
}

export class Produto{
    public Nome? : string;
    public Preco? : string;
    public Imagem?: any;
    public Descricao? : string;
    public Quantidade? : number; 
    constructor(nome?: string, preco?: string, imagem?:any ,descricao?:string, quantidade?: number) {
        this.Nome = nome;
        this.Preco = preco;
        this.Imagem = imagem;
        this.Descricao = descricao;
        this.Quantidade = quantidade
    }
}

export class PedidoExtenso {
    IdPedido?: number;
    NmCliente?: string;
    FoneCliente?: string;
    EnderecoCliente?: string;
    Servicos?:Servico[];
    Preco?:number;
    Status?: Number;
    DataPedido?:Date;
    DataRecebimento?:Date;
    ListaProduto?:Produto[];
    Tipo?:String;
    Taxa?:string;

}