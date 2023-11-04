import { Component } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Pontuacao } from 'src/app/models/Pontuacao';
import { PontuacoesService } from 'src/app/services/pontuacoes.service';

@Component({
  selector: 'app-pontuacoes',
  templateUrl: './pontuacoes.component.html',
  styleUrls: ['./pontuacoes.component.css']
})
export class PontuacoesComponent {
  formulario: any;
  tituloFormulario: string = '';
  constructor(private pontuacaoService: PontuacoesService) { }
  ngOnInit(): void{
    this.tituloFormulario = 'Nova Pontuação';
    this.formulario = new FormGroup({
      score: new FormControl(null),
      usuarioId: new FormControl(null),
      filmeId: new FormControl(null)
    })
  }
  enviarFormulario(): void{
    const pontuacao: Pontuacao = this.formulario.value;
    this.pontuacaoService.cadastrar(pontuacao).subscribe(result => {
      alert("Pontuação inserida com sucesso.");
    })
  }
}
