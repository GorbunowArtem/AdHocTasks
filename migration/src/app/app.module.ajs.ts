import 'angular-route';
import 'angular-animate';

import './core/phone/phone.module';
import './core/phone/phone.service';
import './core/core.module';

import './phone-detail/phone-detail.module';
import './phone-detail/phone-detail.component';

import './phone-list/phone-list.module';
import './phone-list/phone-list.component';
import * as angular from 'angular';

export default angular.module('phonecatApp', [
  'ngAnimate',
  'ngRoute',
  'core',
  'phoneDetail',
  'phoneList',
]);
