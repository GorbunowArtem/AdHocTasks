export default function (appModule: any) {
  appModule.config(function ($routeProvider: any) {
    $routeProvider
      .when('/phones', {
        template: '<phone-list></phone-list>',
      })
      .when('/phones/:phoneId', {
        template: '<phone-detail></phone-detail>',
      })
      .otherwise('/phones');
  });
}
