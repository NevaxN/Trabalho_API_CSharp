import { Component } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Diretor } from 'src/app/models/Diretor';
import { DiretoresService } from 'src/app/services/diretores.service';

@Component({
  selector: 'app-diretores',
  templateUrl: './diretores.component.html',
  styleUrls: ['./diretores.component.css']
})
export class DiretoresComponent {
  formulario: any;
  tituloFormulario: string = '';
  constructor(private diretorService: DiretoresService){ }
  ngOnInit(): void {
    this.tituloFormulario = 'Novo Diretor';
    this.formulario = new FormGroup({
      nome: new FormControl(null)
    })
  }
  enviarFormulario(): void{
    const diretor: Diretor = this.formulario.value;
    this.diretorService.cadastrar(diretor).subscribe(result => {
      alert("Diretor inserido com sucesso.")
    })
  }
}
