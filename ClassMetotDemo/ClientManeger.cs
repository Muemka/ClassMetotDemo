using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class ClientManeger
    {
        public void Add(Client client)
        {
            Console.WriteLine(client.NameSurname + " İsimli Müşteri Eklendi");
        }

        public void Delete(Client client)
        {
            Console.WriteLine(client.NameSurname + " İsimli Müşteri Silindi");
        }

        public void Checking(Client client)
        {
            Console.WriteLine(client.NameSurname + " İsimli Müşterinin Hesap Bakiyesi : " + client.Balance);
        }
        public void PhoneNumber(Client client)
        {
            Console.WriteLine(client.NameSurname + " İsimli Müşterinin Telefon Numarası : " + client.PhoneNumber);
        }
        public void AccounNumber(Client client)
        {
            Console.WriteLine(client.NameSurname + " İsimli Müşterinin Hesap Numarası : " + client.AccountNumber);
        }

        
    }
}
