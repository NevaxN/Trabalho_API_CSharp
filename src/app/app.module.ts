import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import { ReactiveFormsModule } from '@angular/forms';
import { ModalModule } from 'ngx-bootstrap/modal';

import { CatalogosService } from './services/catalogos.service';
import { CatalogoFilmesService } from './services/catalogo-filmes.service';
import { ComentariosService } from './services/comentarios.service';
import { DiretoresService } from './services/diretores.service';
import { FilmesService } from './services/filmes.service';
import { GenerosService } from './services/generos.service';
import { GeneroUsuariosService } from './services/genero-usuarios.service';
import { PontuacoesService } from './services/pontuacoes.service';
import { UsuariosService } from './services/usuarios.service';
import { WatchlistsService } from './services/watchlists.service';
import { CatalogosComponent } from './components/catalogos/catalogos.component';
import { ComentariosComponent } from './components/comentarios/comentarios.component';
import { DiretoresComponent } from './components/diretores/diretores.component';
import { FilmesComponent } from './components/filmes/filmes.component';
import { GenerosComponent } from './components/generos/generos.component';
import { PontuacoesComponent } from './components/pontuacoes/pontuacoes.component';
import { UsuariosComponent } from './components/usuarios/usuarios.component';


@NgModule({
  declarations: [
    AppComponent,
    CatalogosComponent,
    ComentariosComponent,
    DiretoresComponent,
    FilmesComponent,
    GenerosComponent,
    PontuacoesComponent,
    UsuariosComponent
  ],
  imports: [
    BrowserModule,
    CommonModule,
    AppRoutingModule,
    HttpClientModule,
    ReactiveFormsModule,
    ModalModule.forRoot()
  ],
  providers: [HttpClientModule, CatalogosService, CatalogoFilmesService, ComentariosService, DiretoresService, FilmesService, GenerosService, GeneroUsuariosService, PontuacoesService, UsuariosService, WatchlistsService],
  bootstrap: [AppComponent]
})
export class AppModule { }
