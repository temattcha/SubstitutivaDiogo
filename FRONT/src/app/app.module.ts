import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { AlunoCadastrarComponent } from './pages/aluno/aluno-cadastrar/aluno-cadastrar.component';
import { ImcCadastrarComponent } from './pages/imc/imc-cadastrar/imc-cadastrar.component';
import { ImcListarComponent } from './pages/imc/imc-listar/imc-listar.component';
import { ImcAlterarComponent } from './pages/imc/imc-alterar/imc-alterar.component';


@NgModule({
  declarations: [
    AppComponent,
    AlunoCadastrarComponent,
    ImcCadastrarComponent,
    ImcListarComponent,
    ImcAlterarComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
