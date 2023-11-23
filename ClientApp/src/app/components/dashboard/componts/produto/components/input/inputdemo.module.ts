import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { InputDemoComponent } from './inputdemo.component';
import { DialogModule } from 'primeng/dialog';
import { TableModule } from 'primeng/table';
import { RouterModule } from '@angular/router';

@NgModule({
	imports: [
		CommonModule,
		DialogModule,
		TableModule,
		FormsModule,
		RouterModule.forChild([{ path: '', component: InputDemoComponent }]),
	],
	declarations: [InputDemoComponent]
})
export class InputDemoModule { }