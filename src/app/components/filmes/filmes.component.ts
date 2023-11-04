import { Component } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Filme } from 'src/app/models/Filme';
import { FilmesService } from 'src/app/services/filmes.service';

@Component({
  selector: 'app-filmes',
  templateUrl: './filmes.component.html',
  styleUrls: ['./filmes.component.css']
})
export class FilmesComponent {
  formulario: any;
  tituloFormulario: string = '';
  constructor(private filmeService: FilmesService){ }
  ngOnInit(): void{
    this.tituloFormulario = 'Novo Filme';
    this.formulario = new FormGroup({
      titulo: new FormControl(null),
      sinopse: new FormControl(null),
      ano: new FormControl(null),
      diretorId: new FormControl(null)
    })
  }
  enviarFormulario(): void{
    const filme: Filme = this.formulario.value;
    this.filmeService.cadastrar(filme).subscribe(result => {
      alert("Filme inserido com sucesso.");
    })
  }
}
