import { Component } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Catalogo } from 'src/app/models/Catalogo';
import { CatalogosService } from 'src/app/services/catalogos.service';

@Component({
  selector: 'app-catalogos',
  templateUrl: './catalogos.component.html',
  styleUrls: ['./catalogos.component.css']
})
export class CatalogosComponent {
  formulario: any;
  tituloFormulario: string = '';
  constructor(private catalogoService: CatalogosService) { }
  ngOnInit(): void {
    this.tituloFormulario = 'Novo Catalogo';
    this.formulario = new FormGroup({
      descricao: new FormControl(null)
    })
  }
  enviarFormulario(): void{
    const catalogo: Catalogo = this.formulario.value;
    this.catalogoService.cadastrar(catalogo).subscribe(result => {
      alert("Catalogo inserido com sucesso.");
    })
  }
}
