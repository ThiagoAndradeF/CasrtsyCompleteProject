import { NgModule } from '@angular/core';
import {MatButtonToggleModule} from '@angular/material/button-toggle';
import { LandinPageComponent } from './landin-page.component';
import {MatIconModule} from '@angular/material/icon';
import { MicroComponentsModule } from '../micro-components/micro-components/micro-components.module';
import { DialogLoginComponent } from './dialog-login/dialog-login.component';
import { MatDialogModule} from '@angular/material/dialog';
import { MatButtonModule } from '@angular/material/button';
import { RouterModule } from '@angular/router';
import { FormsModule } from '@angular/forms';
import {MatInputModule} from '@angular/material/input';
import {MatFormFieldModule} from '@angular/material/form-field';
import { CommonModule } from '@angular/common';
import {MatSidenavModule} from '@angular/material/sidenav';
import { FlexLayoutModule } from '@angular/flex-layout';
@NgModule({
  declarations: [
    LandinPageComponent,
    DialogLoginComponent
  ],
  imports: [
    FlexLayoutModule,
    MatSidenavModule,
    CommonModule,
    MatButtonToggleModule
  , MatIconModule
  , MicroComponentsModule
  , MatDialogModule
  , MatButtonModule
  , RouterModule.forChild([{ path: '', component: LandinPageComponent }])
  , FormsModule
  , MatFormFieldModule
  , MatInputModule
  ],
  exports: [
    LandinPageComponent,
    DialogLoginComponent
  ]
})
export class LandinPageModule { }
