import { ItemDto } from "./ItemDto";

export class StoreWithItemsDto
{
    public id?:number;
    public  customerName?:string;
    public  name?:string;
    public  items?: ItemDto[];
}
