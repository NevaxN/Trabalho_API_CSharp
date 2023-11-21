import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Catalogo } from 'src/app/models/Catalogo';
import { CatalogosService } from 'src/app/services/catalogos.service';

@Component({
  selector: 'app-catalogos',
  templateUrl: './catalogos.component.html',
  styleUrls: ['./catalogos.component.css']
})
export class CatalogosComponent implements OnInit {
  formulario!: FormGroup;
  tituloFormulario: string = 'Novo Catalogo';

  constructor(private catalogoService: CatalogosService) {}

  ngOnInit(): void {
    this.formulario = new FormGroup({
      descricao: new FormControl(null, Validators.required)
    });
  }

  enviarFormulario(): void {
    if (this.formulario.valid) {
      const catalogo: Catalogo = this.formulario.value;
      this.catalogoService.cadastrar(catalogo).subscribe(
        result => {
          alert('Catalogo inserido com sucesso.');
        },
        error => {
          console.error('Erro ao cadastrar o catálogo:', error);
          alert('Erro ao cadastrar o catálogo.');
        }
      );
    }
  }
}
