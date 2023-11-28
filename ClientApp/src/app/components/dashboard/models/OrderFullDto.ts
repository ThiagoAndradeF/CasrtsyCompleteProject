import { AdditionalServiceDto } from "./AdditionalServiceDto";
import { ItemDto } from "./ItemDto";


export class OrderFullDto {
  storeId?:number;
  consumerName: string ="" ;
  price: number = 0;
  dateCreated: Date = new Date();
  items:ItemDto[] = [];
  services: AdditionalServiceDto[] = [];
  listItemsTitle(){
    let value = " ";
    this.items.forEach(element => {
      value+= element.toString() + ", "
    });
  }
}
