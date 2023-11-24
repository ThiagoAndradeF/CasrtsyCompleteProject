import { RouterModule } from '@angular/router';
import { NgModule } from '@angular/core';
import { NotfoundComponent } from './components/notfound/notfound.component';
import { AppLayoutComponent } from "./layout/app.layout.component";
import { AuthGuard } from './auth.guard'; // Ajuste o caminho conforme necessário

@NgModule({
    imports: [
        RouterModule.forRoot([
            {
                path: '', component: AppLayoutComponent, canActivate: [AuthGuard],
                children: [
                    { path: '', loadChildren: () => import('./components/dashboard/dashboard.module').then(m => m.DashboardModule), canActivateChild: [AuthGuard] },
                    { path: 'uikit', loadChildren: () => import('./components/uikit/uikit.module').then(m => m.UIkitModule), canActivateChild: [AuthGuard] },
                ]
            },
            { path: 'landing', loadChildren: () => import('./components/landing/landing.module').then(m => m.LandingModule) },
            { path: 'login', canActivate: [AuthGuard], loadChildren: () => import('./components/login/login.module').then(m => m.LoginModule) },
            { path: 'cadastro', canActivate: [AuthGuard], loadChildren: () => import('./components/cadastro/cadastro.module').then(m => m.CadastroModule) },
            { path: 'notfound', component: NotfoundComponent },
            { path: '**', redirectTo: '/notfound' },
        ], { scrollPositionRestoration: 'enabled', anchorScrolling: 'enabled', onSameUrlNavigation: 'reload' })
    ],
    exports: [RouterModule]
})
export class AppRoutingModule {
}
