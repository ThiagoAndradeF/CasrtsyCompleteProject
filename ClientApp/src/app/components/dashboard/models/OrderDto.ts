

export class OrderDto {
  storeId?:number;
  consumerName?: string;
  price: number = 0;
  dateCreated: Date = new Date();
  itemIds:number[] = [];
  serviceIds: number[] = [];
}
