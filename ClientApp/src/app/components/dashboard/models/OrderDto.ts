import { AdditionalServiceDto } from "./AdditionalServiceDto";
import { ItemDto } from "./ItemDto";
import { StatusDto } from "./StatusDto";

export class OrderDto {
  consumerName?: string;
  price: number = 0;
  date: Date = new Date();
  itemIds!:number[];
  additionalServiceIds!: number[];
}
