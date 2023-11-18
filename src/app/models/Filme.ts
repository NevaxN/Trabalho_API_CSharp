import { Diretor } from "./Diretor";

export class Filme{
    id: number = 0;
    titulo: string = '';
    sinopse: string = '';
    ano: number = 0;
    diretorId: number = 0;
    diretor: Diretor | undefined;
}