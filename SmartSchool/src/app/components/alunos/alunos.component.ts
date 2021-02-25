import { Component, OnInit, TemplateRef, OnDestroy } from '@angular/core';
import { Aluno } from '../../models/aluno';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { ToastrService } from "ngx-toastr";
import { NgxSpinnerService } from "ngx-spinner";
// import {  } from "../../services/aluno.service";
import { takeUntil } from "rxjs/operators";
import { Subject } from 'rxjs';
// import {  } from "../../services/professor.service";
import { Professor } from '../../models/professor';
import { ActivatedRoute } from "@angular/router";
import { AlunoService } from '../../service/aluno.service';

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
  public textSimple: string;
  public profsAlunos: Professor[];

  private unsubscriber = new Subject();

  public alunos: Aluno[];
  public aluno: Aluno;
  public msnDeleteAluno: string;
  public modeSave: 'post';

  openModal(template: TemplateRef<any>, alunoId: number){

  }

  closeModal(){
    this.modalRef.hide();
  }


  constructor(private fb: FormBuilder,
              private modalService: BsModalService,
              private alunoService: AlunoService) {
    this.criarForm();
   }

  ngOnInit() {
    this.carregarAlunos();
  }

  carregarAlunos(){
    this.alunoService.getAll().subscribe(
      (alunos: Aluno[]) => {
        this.alunos = alunos;
      },
      (erro: any) => {
        console.error(erro);
      }
    );
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
