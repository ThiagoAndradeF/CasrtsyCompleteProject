import { ActivatedRouteSnapshot, CanActivateFn, Router, RouterStateSnapshot } from '@angular/router';

// Função guarda de rota
export const AuthGuard: CanActivateFn = (route:ActivatedRouteSnapshot , state:RouterStateSnapshot ) => {
  const isLoggedIn = localStorage.getItem('authToken') === 'logado';
  // const hasDashboardAccess = localStorage.getItem('dashboardAccess') === 'true';

  if ((state.url.includes('uikit') || state.url.includes('') ) && (!isLoggedIn)) {
    // Se tentar acessar o dashboard sem estar logado ou sem acesso, redireciona
    return false;
  }

  if ((state.url.includes('/login') || state.url.includes('/cadastro')) && isLoggedIn) {
    // Se já estiver logado, não permite acessar login ou cadastro
    return false;
  }

  return true;
};
