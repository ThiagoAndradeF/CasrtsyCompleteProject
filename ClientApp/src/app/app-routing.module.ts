import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LandinPageModule } from './landin-page/landin-page.module';
import { PlataformaClienteModule } from './plataforma-cliente/plataforma-cliente.module';
const routes: Routes = [
  { path: '', component: LandinPageModule },
  { path: 'plataforma', component: PlataformaClienteModule}
];
@NgModule({
  imports: [
    RouterModule.forRoot(routes),
    LandinPageModule,
    PlataformaClienteModule
  ],
  exports: [RouterModule]
})
export class AppRoutingModule { }
