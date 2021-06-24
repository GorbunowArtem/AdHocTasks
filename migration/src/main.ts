import { enableProdMode } from '@angular/core';
import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';

import { AppModule } from './app/app.module';
import { environment } from './environments/environment';

import { setAngularJSGlobal } from '@angular/upgrade/static';

import * as angular from 'angular';

import ajsApp from './app/app.module.ajs';
import states from './app/app.config.ajs';

states(ajsApp);

setAngularJSGlobal(angular);

if (environment.production) {
  enableProdMode();
}

platformBrowserDynamic()
  .bootstrapModule(AppModule)
  .catch((err) => console.error(err));
