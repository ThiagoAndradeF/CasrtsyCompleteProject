<<<<<<< HEAD
import { Component, OnInit, SimpleChanges } from '@angular/core';
import { AdditionalServiceDto } from '../../../../models/AdditionalServiceDto';
import { StoreService } from 'src/app/components/dashboard/shared/store.service';
=======
import { Component, OnInit } from '@angular/core';
import { SelectItem } from 'primeng/api';
import { CountryService } from 'src/app/aplication/service/country.service';

>>>>>>> 1c36d7e6bf131a789429dd2cff0c712d9816e19e
@Component({
    templateUrl: './inputdemo.component.html'
})
export class InputDemoComponent implements OnInit {
<<<<<<< HEAD
    
    private _services : AdditionalServiceDto[] = [];
    public get services() : AdditionalServiceDto[] {
        return this._services;
    }
    public set services(v : AdditionalServiceDto[]) {
        this._services = v;
        // window.location.reload();
    }
    
    selectedService: AdditionalServiceDto = new AdditionalServiceDto();
    displayDialog: boolean = false;
    editedService:AdditionalServiceDto = new AdditionalServiceDto();
    dialogNovoServico: boolean = false;
    displayAddDialog: boolean = false;
    newService: AdditionalServiceDto = new AdditionalServiceDto();
    storeId:number = 0;
  
  
    constructor( private storeService:StoreService) {
    }
  
    ngOnInit() {
      this.listarServicos();
    }
    
    public listarServicos(){
    //   this.storeService.getStoreWithItemsFirstLogin().subscribe(data => {
    //     if(data.items){
    //       this.items = data.items;
    //     }if(data.id)
    //     {this.storeId= data.id;}
    //   });
    }
    public showDialogAdicionarServico(){
      this.dialogNovoServico = true;
    }

    showAddNewDialog() {
      this.newService = new AdditionalServiceDto(); // Reset do produto
      this.displayAddDialog = true; // Mostrar o dialog
    }
   
    addNewService() {
    //   this.storeService.addItemsToStoreById(this.storeId, this.newService).subscribe(data => {
    //     if(data){
    //       console.warn('Produto adicionado!')
    //     }
    //   });;
    //   this.services.push(this.newService); // Adicionar o novo produto à lista
    //   this.displayAddDialog = false; // Fechar o dialog após adicionar
    }
    deleteService(service: AdditionalServiceDto) {
    
=======

    
    constructor(private countryService: CountryService) { }
    ngOnInit(): void {
        
>>>>>>> 1c36d7e6bf131a789429dd2cff0c712d9816e19e
    }

    
}
