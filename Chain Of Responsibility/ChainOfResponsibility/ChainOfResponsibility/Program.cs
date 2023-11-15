using ChainOfResponsibility.Chains.TransferMoney;
using ChainOfResponsibility.Dtos;
using ChainOfResponsibility.Models;

Console.WriteLine("Hello, World!");
var c1 = new Customer
{
    AccountValue = 1000,
    IsActive = false,
    MaxDateValue = 200,
    Password = "123456"
};

var c2 = new Customer
{
    AccountValue = 2500,
    IsActive = true,
    MaxDateValue = 250,
    Password = "654321"
};

var transferMoney1 = new CheckPassword(new CheckUserActivity(new CheckBalance(new TransferOperationFinalizer(null))));
var res = transferMoney1.Execute(new RequestDto
{
    FromCustomer = c1,
    ToCustomer = c2,
    Value = 1800,
    Password = "215405"
});
Console.WriteLine(res.Message);
