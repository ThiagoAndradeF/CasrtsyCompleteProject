import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { TopBarComponent } from './components/top-bar/top-bar.component';
import { PlataformaClienteComponent } from './plataforma-cliente.component';
import { RouterModule } from '@angular/router';
import {MatIconModule} from '@angular/material/icon';
import {MatButtonModule} from '@angular/material/button';
import {MatToolbarModule} from '@angular/material/toolbar';
import {MatMenuModule} from '@angular/material/menu';
import { MenuLateralComponent } from './components/menu-lateral/menu-lateral.component';
import { FlexLayoutModule } from '@angular/flex-layout';
import { CatalogoComponent } from './components/catalogo/catalogo.component';
import { CardCatalogoComponent } from './components/catalogo/cards/card-catalogo/card-catalogo.component';
import { MatInputModule } from '@angular/material/input';
import { SearchInputComponent } from './components/catalogo/search-input/search-input.component';
import { CardCatalogoSkeletonComponent } from './components/catalogo/cards/card-catalogo-skeleton/card-catalogo-skeleton.component';
import { CardCatalogoAddComponent } from './components/catalogo/cards/card-catalogo-add/card-catalogo-add.component';
import { EditCardDialogComponent } from './components/catalogo/cards/edit-card-dialog/edit-card-dialog.component';
import { MatDialogModule } from '@angular/material/dialog';
import { FormsModule, ReactiveFormsModule} from '@angular/forms';
import {MatSelectModule} from '@angular/material/select';
import {MatFormFieldModule} from '@angular/material/form-field';
import { AdicionarServicoComponent } from './components/catalogo/cards/edit-card-dialog/components/adicionar-servico/adicionar-servico.component';
import {MatExpansionModule} from '@angular/material/expansion';
import {MatNativeDateModule} from '@angular/material/core';
import {MatDatepickerModule} from '@angular/material/datepicker';
import { AgGridModule } from 'ag-grid-angular';
import { PedidosService } from './components/tela-pedido/tela-pedidos/shared/services/pedidos.service';
import { MatProgressSpinnerModule } from '@angular/material/progress-spinner';
import { MatTab, MatTabsModule } from '@angular/material/tabs';
@NgModule({
  declarations: [
    PlataformaClienteComponent,
    TopBarComponent,
    MenuLateralComponent,
    CatalogoComponent,
    CardCatalogoSkeletonComponent,
    CardCatalogoComponent,
    SearchInputComponent,
    CardCatalogoAddComponent,
    EditCardDialogComponent,
    AdicionarServicoComponent
  ],
  imports: [
    FlexLayoutModule,
    MatMenuModule,
    MatToolbarModule,
    MatButtonModule, 
    MatIconModule,
    MatInputModule,
    MatDialogModule,
    MatTabsModule,
    CommonModule, 
    FormsModule, 
    ReactiveFormsModule,
    MatFormFieldModule,
    MatSelectModule,
    MatProgressSpinnerModule,
    MatExpansionModule,
    MatDatepickerModule,
    MatNativeDateModule,
    AgGridModule,
    RouterModule.forChild([{ path: 'plataforma', component: PlataformaClienteComponent }])
  ],
  providers: [
    PedidosService
  ]
})
export class PlataformaClienteModule { }
