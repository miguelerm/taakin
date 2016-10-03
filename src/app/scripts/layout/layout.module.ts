import { NgModule }           from '@angular/core';
import { CommonModule }       from '@angular/common';
import { FormsModule }        from '@angular/forms';

import { SidebarComponent } from './sidebar.component';

@NgModule({
  imports:      [ CommonModule, FormsModule ],
  declarations: [ SidebarComponent ],
  exports:      [ SidebarComponent ]
})
export class LayoutModule { }
