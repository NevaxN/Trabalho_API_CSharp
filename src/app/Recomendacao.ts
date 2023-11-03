import { Usuario } from "./Usuario";

export class Recomendacao{
    id: number = 0;
    usuarioId: number = 0;
    usuario: Usuario | null = null;
}