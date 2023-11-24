import { Component, OnInit, SimpleChanges } from '@angular/core';
import { AdditionalServiceDto } from '../../../../models/AdditionalServiceDto';
import { StoreService } from 'src/app/components/dashboard/shared/store.service';
@Component({
    templateUrl: './inputdemo.component.html',
    styleUrls: ['./inputdemo.component.scss'],
})
export class InputDemoComponent implements OnInit {

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
      this.storeService.getStoreWithServices().subscribe(data => {
        if(data.services){
          this.services = data.services;
        }
      });
    }
    public showDialogAdicionarServico(){
      this.dialogNovoServico = true;
    }

    showAddNewDialog() {
      this.newService = new AdditionalServiceDto(); // Reset do produto
      this.displayAddDialog = true; // Mostrar o dialog
    }

    addNewService() {
      this.storeService.addServicesToStoreById(this.newService).subscribe(data => {
        if(data){
          console.log('Serviço adicionado!')
        }
      });;
      this.services.push(this.newService); // Adicionar o novo produto à lista
      this.displayAddDialog = false; // Fechar o dialog após adicionar
    }
    deleteService(service: AdditionalServiceDto) {
      // if(service.id){
      //   this.storeService.removeItemById(this.storeId, iten.id).subscribe();
      //   setTimeout(() => {
      //     location.reload();
      //   }, 1000);
      // }

    }


}
