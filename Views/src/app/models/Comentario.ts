import { Filme } from "./Filme";
import { Usuario } from "./Usuario";

export class Comentario{
    id: number = 0;
    texto: string = '';
    usuarioId: number = 0;
    usuario: Usuario | undefined;
    filmeId: number = 0;
    filme: Filme | undefined;
}