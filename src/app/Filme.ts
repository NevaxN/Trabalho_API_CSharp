import { CatalogoFilme } from "./CatalogoFilme";
import { Comentario } from "./Comentario";
import { Diretor } from "./Diretor";
import { GeneroFilmes } from "./GeneroFilmes";

export class Filme{
    id: number = 0;
    titulo: string = '';
    sinopse: string = '';
    ano: number = 0;
    diretorId: number = 0;
    diretor: Diretor | null = null;
    catalogoFilmes: CatalogoFilme[] =[];
    catalogoIds: number[] = [];
    comentarios: Comentario[] = [];
    generoFilmes: GeneroFilmes[] = [];
}