import { ItemDto } from "./ItemDto";

export class StoreWithItemsDto
{
    public  customerName?:string;
    public  name?:string;
    public  items?: ItemDto[];
}
