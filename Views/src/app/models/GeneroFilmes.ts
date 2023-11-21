import { Filme } from "./Filme";
import { Genero } from "./Genero";

export class GeneroFilmes{
    id: number = 0;
    filmeId: number = 0;
    filme: Filme | undefined;
    generoId: number = 0;
    genero: Genero | undefined;
}