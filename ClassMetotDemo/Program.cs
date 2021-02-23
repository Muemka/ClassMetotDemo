using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client1 = new Client();
            client1.NameSurname = "Emre";
            client1.Id = 111111111;
            client1.AccountNumber = 1;
            client1.Balance = 65000;
            client1.PhoneNumber = "0511 111 11 11";

            Client client2 = new Client();
            client2.Id = 222222222;
            client2.NameSurname = "Engin";
            client2.AccountNumber = 2;
            client2.PhoneNumber = "0522 222 22 22";
            client2.Balance = 185683;

            Client client3 = new Client();
            client3.Id = 3333333;
            client3.NameSurname = "Aslı";
            client3.AccountNumber = 3;
            client3.PhoneNumber = "0599 999 99 99";
            client3.Balance = 8573;

            Client[] clients = new Client[] {client1,client2,client3,};

            ClientManeger CM = new ClientManeger();

            foreach (Client client in clients)
            {
                CM.Add(client);
                CM.AccounNumber(client);
                CM.Checking(client);
                CM.PhoneNumber(client);
                CM.Delete(client);
            }
        }
    }
}
