import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CatalogosComponent } from './components/catalogos/catalogos.component';
import { ComentariosComponent } from './components/comentarios/comentarios.component';
import { DiretoresComponent } from './components/diretores/diretores.component';
import { FilmesComponent } from './components/filmes/filmes.component';
import { GenerosComponent } from './components/generos/generos.component';
import { PontuacoesComponent } from './components/pontuacoes/pontuacoes.component';
import { UsuariosComponent } from './components/usuarios/usuarios.component';

const routes: Routes = [
  {path: 'catalogos', component: CatalogosComponent},
  {path: 'comentarios', component: ComentariosComponent},
  {path: 'diretores', component: DiretoresComponent},
  {path: 'filmes', component: FilmesComponent},
  {path: 'generos', component: GenerosComponent},
  {path: 'pontuacoes', component: PontuacoesComponent},
  {path: 'usuarios', component: UsuariosComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
