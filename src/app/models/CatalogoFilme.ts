import { Catalogo } from "./Catalogo";
import { Filme } from "./Filme";

export class CatalogoFilme{
    id: number = 0;
    filmeId: number = 0;
    filmeTitulo: string = '';
    filme: Filme | undefined;
    catalogoId: number = 0;
    catalogo: Catalogo | undefined;
}
