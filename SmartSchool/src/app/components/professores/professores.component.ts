import { Component, OnInit, TemplateRef } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { Professor } from '../../models/professor';

@Component({
  selector: 'app-professores',
  templateUrl: './professores.component.html',
  styleUrls: ['./professores.component.css']
})
export class ProfessoresComponent implements OnInit {

  public modalRef: BsModalRef;
  public professorForm: FormGroup;
  public titulo = "Professores";
  public professorSelecionado: Professor;

  public professores = [
    { id: 1, nome: 'Carlos', disciplina: 'Matemática' },
    { id: 2, nome: 'Iago', disciplina: 'Física' },
    { id: 3, nome: 'Tereza', disciplina: 'Português' },
    { id: 4, nome: 'Aline', disciplina: 'Programação' }
  ];

  constructor(private fb: FormBuilder, private modalService: BsModalService) {
    this.criarForm();
   }

   openModal(template: TemplateRef<any>){
     this.modalRef = this.modalService.show(template);
   }

  ngOnInit() {
  }

  criarForm(){
    this.professorForm = this.fb.group({
      nome: ['', Validators.required],
      disciplina: ['', Validators.required]
    });
  }

  professorSubmit(){
    console.log(this.professorForm.value);
  }

  professorSelect(professor: Professor){
    this.professorSelecionado = professor;
    this.professorForm.patchValue(professor);
  }

  voltar(){
    this.professorSelecionado = null;
  }


}
