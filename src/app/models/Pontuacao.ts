import { Filme } from "./Filme";
import { Usuario } from "./Usuario";

export class Pontuacao{
    id: number = 0;
    score: number = 0.0;
    usuarioId: number = 0;
    usuario: Usuario | undefined;
    filmeId: number = 0;
    filme: Filme | undefined;
}