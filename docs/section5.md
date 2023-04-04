**creating a nav bar in angular**
* creating nav component using command ng g c nav --skip-tests

**angular template form**
*import the formmodule then create a function login in the nav model. After that we have to put the attributes in the form of nav html . like reference variable and the function refernce after submit and add the properties tag to form properties*

**creating services in angular**
 application that needs to make API calls to retrieve data from a server. Rather than duplicating the code to make those API calls in every component that needs to use them, you can create a service that encapsulates that functionality
 *use the command ng g s _services/serviceName*
 *after creating service , then we have to inject the into our components.*

 **structural directives in angular**
 allow you to add, remove, or manipulate the structure of the HTML DOM based on certain conditions.
 --><div *ngIf="isLoggedIn">
 --> <li *ngFor="let item of items">{{ item }}</li>
 --><div [ngSwitch]="status">  <div *ngSwitchCase="'online'"

 **using angular bootstrap dropdown**
 add the api from the angular bootstrap drop down component "ng add ngx-bootstrap  --component dropdowns"
 --> just use the structural directives to show the content of dropdown

 **observables in angular**
 it provide an efficient and flexible way to handle asynchronous data streams.<b> Observables are like newsletter, only subscribers of the newsletter recieves the newsletter, it can also be used with many filters.</b>
* <u>Reactive programming</u>: Angular is designed around the concept of reactive programming, where data flows continuously and asynchronously through the application. Observables are a key component of reactive programming because they allow developers to create data streams that can be subscribed to and manipulated as needed.

* <u>Asynchronous data</u>: Many of the operations in Angular, such as HTTP requests or user interactions, involve asynchronous data streams. Observables provide a way to handle these data streams in a predictable and efficient manner.

* <u>Event handling</u>: In Angular, events are represented as observables, which allows developers to easily handle user interactions and other events in the application.

**persisting the Login**
For this we need to store the login credentials into our local storage on client side.
<b>steps:</b>
-->for this we have to transformed the value returned value from the http post method. For that we use the pipe(*simple functions to use in template expressions to accept an input value and return a transformed value*) 
-->storing the user information in the login method , will work only on the specific component. but using this functionality everywhere we have to use <b>Behaviour Subject</b>(*type of Subject that allows you to set an initial value and emits its current value whenever a new observer subscribes to it.*)
-->after creating the behaviour subject, we have to register the account service in app component.

**async pipe in the angular**
*allows you to subscribe to an Observable or a Promise in a component template, and automatically update the view when the data is available or changes*
when we use the async pipe , then we dont have to maintain the flag for the logging in.

**Parent to child Communication**
Input bindings: Input bindings allow a parent component to pass data to a child component. In the parent component, you can define a property with the @Input
<b>@Output is used for the child to parent communication</b>