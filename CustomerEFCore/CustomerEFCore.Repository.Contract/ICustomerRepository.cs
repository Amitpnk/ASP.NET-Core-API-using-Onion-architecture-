﻿using CustomerEFCore.Domain;
using System.Threading.Tasks;

namespace CustomerEFCore.Repository.Contract
{
    public interface ICustomerRepository
    {
        // General 
        bool SaveChangesAsync();


        // Customer
        void AddCustomer(Customer customer);
        void DeleteCustomer(Customer customer);
        Task<Customer[]> GetAllCustomersAsync(bool includeOrders = false);
        Task<Customer> GetCustomerAsync(string customerName, bool includeOrders = false);

    }
}