// See https://aka.ms/new-console-template for more information


using CircularDependencyApi;
using CircularDependencyApi.Interfaces;
using CircularDependencyApi.Operations;
using Microsoft.Extensions.DependencyInjection;


#region Circular Dependency Problem

//var collection = new ServiceCollection();
//collection.AddTransient<ISMSOperations, SMSOperations>();
//collection.AddTransient<IEMailOperations, EMailOperations>();
//IServiceProvider provider = collection.BuildServiceProvider();

//var serviceProviderSMSOperation = provider.GetService<ISMSOperations>();
//var serviceProviderEMailOperation = provider.GetService<IEMailOperations>();

#endregion


#region Circular Dependency Solition

var collection = new ServiceCollection();
collection.AddTransient<ISMSOperations, SMSOperationsWorker>();
collection.AddTransient<IEMailOperations, EMailOperationsWorker>();
IServiceProvider provider = collection.BuildServiceProvider();

var serviceProviderSMSOperation = provider.GetService<ISMSOperations>();
var serviceProviderEMailOperation = provider.GetService<IEMailOperations>();
var serviceProviderCustomerOperation = provider.GetService<CustomerOperations>();

#endregion

