import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { InputDemoComponent } from './inputdemo.component';
<<<<<<< HEAD
import { DialogModule } from 'primeng/dialog';
import { TableModule } from 'primeng/table';
import { RouterModule } from '@angular/router';
=======
import { InputDemoRoutingModule } from './inputdemo-routing.module';
import { AutoCompleteModule } from "primeng/autocomplete";
import { CalendarModule } from "primeng/calendar";
import { ChipsModule } from "primeng/chips";
import { ChipModule } from "primeng/chip";
import { DropdownModule } from "primeng/dropdown";
import { InputMaskModule } from "primeng/inputmask";
import { InputNumberModule } from "primeng/inputnumber";
import { CascadeSelectModule } from "primeng/cascadeselect";
import { MultiSelectModule } from "primeng/multiselect";
import { InputTextareaModule } from "primeng/inputtextarea";
import { InputTextModule } from "primeng/inputtext";
import { RatingModule } from 'primeng/rating';
import { KnobModule } from 'primeng/knob';
import { ListboxModule } from 'primeng/listbox';
import { SelectButtonModule } from 'primeng/selectbutton';
import { CheckboxModule } from 'primeng/checkbox';
import { ButtonModule } from 'primeng/button';
import { InputSwitchModule } from 'primeng/inputswitch';
import { RadioButtonModule } from 'primeng/radiobutton';
import { ColorPickerModule } from 'primeng/colorpicker';
import { ToggleButtonModule } from 'primeng/togglebutton';
import { SliderModule } from 'primeng/slider';
import { DialogModule } from 'primeng/dialog';
import { TableModule } from 'primeng/table';
>>>>>>> 1c36d7e6bf131a789429dd2cff0c712d9816e19e

@NgModule({
	imports: [
		CommonModule,
		DialogModule,
		TableModule,
		FormsModule,
<<<<<<< HEAD
		RouterModule.forChild([{ path: '', component: InputDemoComponent }]),
=======
>>>>>>> 1c36d7e6bf131a789429dd2cff0c712d9816e19e
	],
	declarations: [InputDemoComponent]
})
export class InputDemoModule { }
