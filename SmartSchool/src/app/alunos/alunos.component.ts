import { Component, OnInit, TemplateRef } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { Aluno } from '../models/aluno';

@Component({
  selector: 'app-alunos',
  templateUrl: './alunos.component.html',
  styleUrls: ['./alunos.component.css']
})
export class AlunosComponent implements OnInit {

  public modalRef: BsModalRef;
  public alunoForm: FormGroup;
  public titulo = 'Alunos';
  public alunoSelecionado: Aluno;


  public alunos = [
    { id: 1, nome: 'Marta', sobrenome: 'Kent', telefone: 33225566 },
    { id: 2, nome: 'Laura', sobrenome: 'Isabela', telefone: 22770011 },
    { id: 3, nome: 'Paula', sobrenome: 'Antonia', telefone: 54781232 },
    { id: 4, nome: 'Luiza', sobrenome: 'Maria', telefone: 3214456 },
    { id: 5, nome: 'Lucas', sobrenome: 'Machado', telefone: 89898989 },
    { id: 6, nome: 'Pedro', sobrenome: 'Alvares', telefone: 65432110 },
    { id: 7, nome: 'Paulo', sobrenome: 'José', telefone: 78986545 }
  ];


  openModal(template: TemplateRef<any>){
    this.modalRef = this.modalService.show(template);
  }

  constructor(private fb: FormBuilder, private modalService: BsModalService) {
    this.criarForm();
   }

  ngOnInit(): void {
  }

  criarForm(){
    this.alunoForm = this.fb.group({
      nome:['', Validators.required],
      sobrenome: ['', Validators.required],
      telefone: ['', Validators.required]
    });
  }

  alunoSubmit(){
    console.log(this.alunoForm.value);

  }

  alunoSelect(aluno: Aluno){
    this.alunoSelecionado = aluno;
    this.alunoForm.patchValue(aluno);
  }

  voltar(){
    this.alunoSelecionado = null
  }


}
