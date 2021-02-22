import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-alunos',
  templateUrl: './alunos.component.html',
  styleUrls: ['./alunos.component.css']
})
export class AlunosComponent implements OnInit {

  public titulo = 'Alunos';
  public alunoSelecionado: string;

  public alunos = [
    { id: 1, nome: 'Marta', sobrenome: 'Kent', telefone: 33225566 },
    { id: 2, nome: 'Laura', sobrenome: 'Isabela', telefone: 22770011 },
    { id: 3, nome: 'Paula', sobrenome: 'Antonia', telefone: 54781232 },
    { id: 4, nome: 'Luiza', sobrenome: 'Maria', telefone: 3214456 },
    { id: 5, nome: 'Lucas', sobrenome: 'Machado', telefone: 89898989 },
    { id: 6, nome: 'Pedro', sobrenome: 'Alvares', telefone: 65432110 },
    { id: 7, nome: 'Paulo', sobrenome: 'José', telefone: 78986545 }
  ];

  alunoSelect(aluno: any){
    this.alunoSelecionado = aluno.nome;
  }

  voltar(){
    this.alunoSelecionado = '';
  }

  constructor() { }

  ngOnInit(): void {
  }

}
