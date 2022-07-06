import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent implements OnInit {

  constructor() { }

  public eventos: any = [
    {
      nome: "palestra",
      lote: "1 Lote"
    },
    {
      nome: "palestra",
      lote: "1 Lote"
    },
    {
      nome: "palestra",
      lote: "1 Lote"
    }
  ]

  ngOnInit(): void {
  }

}
