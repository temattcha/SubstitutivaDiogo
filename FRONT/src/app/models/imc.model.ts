import{ Aluno } from "./aluno.model";

export interface Imc
{
    imcId: number;
    imcValor: number;
    pesoEmKg: number;
    alturaEmMetros: number;
    classificacao: string;
    criadoEm?: string;
    alunoId: number;
    aluno?: Aluno;
}