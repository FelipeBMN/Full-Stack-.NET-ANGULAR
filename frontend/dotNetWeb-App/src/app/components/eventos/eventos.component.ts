import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent implements OnInit {

  constructor(private http: HttpClient) { }

  public eventos: any = [];
  public eventosFiltrados: any = [];

  larguraImg: number = 100;
  margemImg: number = 10;
  mostrarImg: boolean = true;
  private _filtroLista: string = '';

  ngOnInit(): void {
    this.getEventos();
  }

  public imgViewer(): void {
    this.mostrarImg = !this.mostrarImg;
  }

  public buscar() {
  }

  public get filtroLista(): string{
    return this._filtroLista
  }

  public set filtroLista(value: string){
    this._filtroLista = value;
    this.eventosFiltrados = this.filtroLista ? this.filtrarEventos(this.filtroLista) : this.eventos;
  }

  filtrarEventos(filtrarPor: string):any{
    filtrarPor= filtrarPor.toLocaleLowerCase();
    return this.eventos.filter(
      (evento: any) => evento.tema.toLocaleLowerCase().indexOf(filtrarPor) !== -1 ||
       evento.local.toLocaleLowerCase().indexOf(filtrarPor) !== -1
    )
  }

  public getEventos(): void {
    this.http.get('https://localhost:5001/Events').subscribe(
      response => {
        this.eventos = response
        this.eventosFiltrados = this.eventos
      },
      error => console.log(error)
    );
  }

}
