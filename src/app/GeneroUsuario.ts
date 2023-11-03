import { Genero } from "./Genero";
import { Usuario } from "./Usuario";

export class GeneroUsuario{
    id: number = 0;
    usuarioId: number = 0;
    usuario: Usuario | null = null;
    generoId: number = 0;
    genero: Genero | null = null;
}