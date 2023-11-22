import { Component, OnInit } from '@angular/core';
import { SelectItem } from 'primeng/api';
import { CountryService } from 'src/app/aplication/service/country.service';

@Component({
    templateUrl: './inputdemo.component.html'
})
export class InputDemoComponent implements OnInit {

    
    constructor(private countryService: CountryService) { }
    ngOnInit(): void {
        
    }

    
}
