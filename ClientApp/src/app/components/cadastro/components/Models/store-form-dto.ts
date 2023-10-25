export class StoreFormDto
{
  public Name !: string;
  public Email !: string;
  public Items !: ItemDto[];
  public Services !: AdditionalServiceDto[];
}
export class AdditionalServiceDto{
  public service !: string;
  public price !: number;
  public type !: string;

  constructor(_service:string, _price:number, _type:string){
    this.service = _service;
    this.price = _price;
    this.type = _type;
  }
}
export class TypeDto{
  public type !: string;
  public tax !: number;

  constructor(type:string){
    this.tax = 1;
    this.type = type;
  }
}
export class ItemDto{
  public name !: string;
  public price !: number;
  public description !: string;
  public stock !: number;
  public type !: TypeDto;

  // constructor(_service:string, _price:number, _description:string, _type:TypeDto){
  //   this.name = _service;
  //   this.price = _price;
  //   this.description = _description;
  //   this.stock = 1;
  //   this.type = _type;
  // }
}


