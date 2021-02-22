import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-professores',
  templateUrl: './professores.component.html',
  styleUrls: ['./professores.component.css']
})
export class ProfessoresComponent implements OnInit {

  public titulo = "Professores";
  public professorSelecionado: string;

  public professores = [
    { id: 1, nome: 'Carlos', disciplina: 'Matemática' },
    { id: 2, nome: 'Iago', disciplina: 'Física' },
    { id: 3, nome: 'Tereza', disciplina: 'Português' },
    { id: 4, nome: 'Aline', disciplina: 'Programação' }
  ];

  professorSelect(professor: any){
    this.professorSelecionado = professor.nome;
  }

  voltar(){
    this.professorSelecionado = '';
  }

  constructor() { }

  ngOnInit() {
  }

}
