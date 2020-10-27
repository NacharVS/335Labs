using System;
using System.Collections.Generic;
using System.Linq;

namespace _335Labs.Shagaviev_Barygin
{ }
public class Bank
{
    public static void OpenNewAccount(Client client)
    {
        var account = new Account
        {

            Balance = ReadBalance("Введите баланс")

        };
        client.CreateAccount(account);
        Console.WriteLine($"Клиент №{client.ID} {client.FullName} был успешно добавлен");
    }

    private object ReadBalance(string v)
    {
        throw new NotImplementedException();
    }
}

public class Main
{
    int a = DateTime.Now.Year;
}

internal class Client
{
    public object FullName { get; internal set; }
    public object ID { get; internal set; }

    internal void CreateAccount(Account account)
    {
        throw new NotImplementedException();
    }
}

internal class Account
{
    public object Balance { get; set; }
}