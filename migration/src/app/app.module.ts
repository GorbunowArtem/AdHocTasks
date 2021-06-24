import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { UpgradeModule } from '@angular/upgrade/static';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

@NgModule({
  declarations: [AppComponent],
  imports: [BrowserModule, AppRoutingModule, UpgradeModule],
  providers: [],
  bootstrap: [],
})
export class AppModule {
  public constructor(private upgrade: UpgradeModule) {}

  ngDoBootstrap() {
    this.upgrade.bootstrap(document.documentElement, ['phonecatApp']);
  }
}
