import { GeneroUsuario } from "./GeneroUsuario";
import { Watchlist } from "./Watchlist";

export class Usuario{
    id: number = 0;
    nome: string = '';
    login: string = '';
    senha: string = '';
    watchlists: Watchlist[] = [];
    generoUsuarios: GeneroUsuario[] = [];
    filmeIds: number[] = [];
}