import { Component } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Comentario } from 'src/app/models/Comentario';
import { ComentariosService } from 'src/app/services/comentarios.service';

@Component({
  selector: 'app-comentarios',
  templateUrl: './comentarios.component.html',
  styleUrls: ['./comentarios.component.css']
})
export class ComentariosComponent {
  formulario: any;
  tituloFormulario: string = '';
  constructor(private comentarioService : ComentariosService){ }
  ngOnInit(): void {
    this.tituloFormulario = 'Novo Comentario';
    this.formulario = new FormGroup({
      texto: new FormControl(null),
      usuarioId: new FormControl(null),
      filmeId: new FormControl(null),
    })
  }
  enviarFormulario(): void{
    const comentario: Comentario = this.formulario.value;
    this.comentarioService.cadastrar(comentario).subscribe(result => {
      alert("Comentario inserido com sucesso.");
    }) 
  }
}