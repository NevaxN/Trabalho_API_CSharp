import { Genero } from "./Genero";
import { Usuario } from "./Usuario";

export class GeneroUsuario{
    id: number = 0;
    usuarioId: number = 0;
    usuario: Usuario | undefined;
    generoId: number = 0;
    genero: Genero | undefined;
}