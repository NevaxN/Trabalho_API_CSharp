import { Component } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Genero } from 'src/app/models/Genero';
import { GenerosService } from 'src/app/services/generos.service';

@Component({
  selector: 'app-generos',
  templateUrl: './generos.component.html',
  styleUrls: ['./generos.component.css']
})
export class GenerosComponent {
  formulario: any;
  tituloFormulario: string = '';
  constructor(private generoService: GenerosService){ }
  ngOnInit(): void{
    this.tituloFormulario = 'Novo Genero';
    this.formulario = new FormGroup({
      generoTipo: new FormControl(null)
    })
  }
  enviarFormulario(): void{
    const genero: Genero = this.formulario.value;
    this.generoService.cadastrar(genero).subscribe(result => {
      alert("Genero inserido com sucesso.")
    })
  }
}
