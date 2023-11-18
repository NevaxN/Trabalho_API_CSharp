import { Component } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Usuario } from 'src/app/models/Usuario';
import { UsuariosService } from 'src/app/services/usuarios.service';

@Component({
  selector: 'app-usuarios',
  templateUrl: './usuarios.component.html',
  styleUrls: ['./usuarios.component.css']
})
export class UsuariosComponent {
  formulario: any;
  tituloFormulario: string = '';
  constructor(private usuarioService: UsuariosService) { }
  ngOnInit(): void{
    this.tituloFormulario = 'Novo Usuario';
    this.formulario = new FormGroup({
      nome: new FormControl(null),
      login: new FormControl(null),
      senha: new FormControl(null)
    })
  }
  enviarFormulario(): void{
    const usuario: Usuario = this.formulario.value;
    this.usuarioService.cadastrar(usuario).subscribe(result => {
      alert("Usuario inserido com sucesso.");
    })
  }
}
