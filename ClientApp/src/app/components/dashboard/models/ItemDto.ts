import { TypeDto } from "./typeDto";

export class ItemDto
{
    public name ?: string ;
    public price ?:number;
    public description?: string = "Padrao";
    public stock?:number;
    public type?:TypeDto = new TypeDto();
    public id?:number = 1;
}
