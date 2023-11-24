export class AdditionalServiceDto{
    public id?:number;
    public service ?: string;
    public price !: number | RegExp;
    public type : string = 'Padrao';
}
