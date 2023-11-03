import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import { ReactiveFormsModule } from '@angular/forms';
import { ModalModule } from 'ngx-bootstrap/modal';

import { CatalogosService } from './catalogos.service';
import { CatalogoFilmesService } from './catalogo-filmes.service';
import { ComentariosService } from './comentarios.service';
import { DiretoresService } from './diretores.service';
import { FilmesService } from './filmes.service';
import { GenerosService } from './generos.service';
import { GeneroUsuariosService } from './genero-usuarios.service';
import { PontuacoesService } from './pontuacoes.service';
import { UsuariosService } from './usuarios.service';
import { WatchlistsService } from './watchlists.service';
import { CatalogosComponent } from './components/catalogos/catalogos.component';


@NgModule({
  declarations: [
    AppComponent,
    CatalogosComponent
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
