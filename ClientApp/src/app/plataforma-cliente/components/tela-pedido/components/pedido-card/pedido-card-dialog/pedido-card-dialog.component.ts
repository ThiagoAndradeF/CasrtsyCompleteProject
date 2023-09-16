import { Component, Input, HostBinding, Inject } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { BreakpointObserver, Breakpoints } from '@angular/cdk/layout';
import * as _ from 'lodash' ;
export interface Tile {
  color: string;
  cols: number;
  rows: number;
  text: string;
}
@Component({
  selector: 'app-pedido-card-dialog',
  templateUrl: './pedido-card-dialog.component.html',
  styleUrls: ['./pedido-card-dialog.component.css']
})


export class PedidoCardDialogComponent {

  @HostBinding('style.display') display = 'block';
  @Input() label?: string;
  public ativarCampoFup = false;
  private _value: any;
  public displayMovel:boolean = false;




  @Input()
  public get value(): any { return this._value; }
  public set value(value: any) {
    this._value = _.toString(this.obterTextoPorHtml(value));
  }
  private _fupValue: any;

  @Input()
  public get fupValue(): any { return this._fupValue; }
  public set fupValue(fupValue: any) {
    this._fupValue = fupValue;
    debugger
    if (fupValue) {
      debugger
      fupValue.dtFup = _.toString(this.obterTextoPorHtml(fupValue.dtFup));
      fupValue.dsFup = _.toString(this.obterTextoPorHtml(fupValue.dsFup));
      if(fupValue.length > 0){
        this.ativarCampoFup=true;
      }

    }
  }

  constructor(
    public dialogRef: MatDialogRef<PedidoCardDialogComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any,
    private breakpointObserver:BreakpointObserver
    ) { }

  private obterTextoPorHtml(html: string) {
    if (_.isNil(html)) html = '';
    return this.decodeHtml(html
      .replace(/(<([^>]+)>)/ig, "")
      .replace(/<span[^>]*>/g, "")
      .replace(/<\/span[^>]*>/g, "")
      .replace(/&nbsp;/g, " ")
    )
  }

  private decodeHtml(html: string) {
    const txt = document.createElement("textarea");
    txt.innerHTML = html;
    return txt.value;
  }

  ngOnInit(): void {
    // Verifica se o dispositivo é móvel
    this.breakpointObserver.observe([Breakpoints.Handset])
      .subscribe(result => {
        if (result.matches) {
          this.displayMovel= true;
        } else {
          this.displayMovel= false;
        }
      });
  }







}
