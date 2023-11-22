import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';

@NgModule({
    imports: [RouterModule.forChild([
        { path: 'produto', data: { breadcrumb: 'Produto' }, loadChildren: () => import('../dashboard/componts/produto/produto.module').then(m => m.ProdutoModule) },
        { path: 'input', data: { breadcrumb: 'Input' }, loadChildren: () => import('../dashboard/componts/produto/components/input/inputdemo.module').then(m => m.InputDemoModule) },
        { path: '**', redirectTo: '/notfound' }
    ])],
    exports: [RouterModule]
})
export class UIkitRoutingModule { }
