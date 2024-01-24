import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'bold'
})
export class BoldPipe implements PipeTransform {

  transform(value: string, term: string): string {
    return value.replace(new RegExp(term, 'g'), `<b>${term}</b>`);
  }

}
