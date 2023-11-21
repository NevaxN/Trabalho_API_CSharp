import { Filme } from "./Filme";
import { Usuario } from "./Usuario";

export class Watchlist{
    id: number = 0;
    filmeId: number = 0;
    filme: Filme | undefined;
    usuarioId: number = 0;
    usuario: Usuario | undefined;
}