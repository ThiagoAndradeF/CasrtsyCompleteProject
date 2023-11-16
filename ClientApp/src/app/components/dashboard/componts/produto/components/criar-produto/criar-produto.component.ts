import { Component } from '@angular/core';
import { ItemDto } from 'src/app/components/dashboard/models/ItemDto';

@Component({
  selector: 'app-criar-produto',
  templateUrl: './criar-produto.component.html',
  styleUrls: ['./criar-produto.component.scss']
})
export class CriarProdutoComponent {
  public novoItem: ItemDto = new ItemDto();


  
}
