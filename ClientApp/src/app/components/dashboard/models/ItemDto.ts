import { TypeDto } from "./typeDto";

export class ItemDto
{
    public name ?: string;
    public price?:number;
    public description?: string;
    public stock?:number;
    public type?:TypeDto;
    public id?:number;
}
