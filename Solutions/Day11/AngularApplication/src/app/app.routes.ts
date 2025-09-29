import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

export const routes: Routes = [
  { path: '', redirectTo: '/products', pathMatch: 'full' }, // default page
  { 
    path: 'auth', 
    loadChildren: () => import('./features/auth/auth.module').then(m => m.AuthModule) 
  },
  { 
    path: 'products', 
    loadChildren: () => import('./features/products/products.module').then(m => m.ProductsModule) 
  },
  { 
    path: 'cart', 
    loadChildren: () => import('./features/cart/cart.module').then(m => m.CartModule) 
  },
  { 
    path: 'orders', 
    loadChildren: () => import('./features/orders/orders.module').then(m => m.OrdersModule) 
  },
  { path: '**', redirectTo: '/products' } // fallback for unknown routes
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {}
