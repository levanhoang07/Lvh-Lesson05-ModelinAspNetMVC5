using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lvh_Lab04_2.Models
{
    // Định nghĩa lớp CustomerRepository thực thi từ giao diện ICustomerRepository
    public class CustomerRepository : ICustomerRepository
    {
        // Khởi tạo danh sách khách hàng
        private static readonly List<Customer> data = new List<Customer>()
        {
            new Customer(){ CustomerId = "KH001",

                FullName = "Lê Văn Hoàng",Address = "Hà Nội",

                Email = "devmaster.founder@gmail.com",

                Phone = "0982.121.680",Balance = 15200000},

                new Customer(){ CustomerId = "KH002",

                FullName = "Đỗ Thị Cúc",Address = "Hà Nội",

                Email = "cucdt@gmail.com",Phone = "0986.767.444",

                Balance = 2200000},

                new Customer(){ CustomerId = "KH003",

                FullName = "Nguyễn Tuấn Thắng",Address = "Nam Định",

                Email = "thangnt@gmail.com",Phone = "0924.656.542",

                Balance = 1200000},

                new Customer(){ CustomerId = "KH004",

                FullName = "Lê Ngọc Hải",Address = "Hà Nội",

                Email = "hailn@gmail.com",Phone = "0996.555.267",

                Balance = 6200000}

                };

        public IList<Customer> GetCustomers()
        {
            return data;
        }

        public IList<Customer> SearchCustomer(string name)
        {
            return data.Where(c => c.FullName.Contains(name)).ToList();
        }

        public Customer GetCustomer(string customerId)
        {
            return data.FirstOrDefault(c => c.CustomerId.Equals(customerId));
        }

        public void AddCustomer(Customer cus)
        {
            data.Add(cus);
        }

        public void UpdateCustomer(Customer cus)
        {
            var customer = data.FirstOrDefault(c => c.CustomerId.Equals(cus.CustomerId));
            if (customer != null)
            {
                customer.FullName = cus.FullName;
                customer.Address = cus.Address;
                customer.Email = cus.Email;
                customer.Phone = cus.Phone;
                customer.Balance = cus.Balance;
            }
        }


        public void DeleteCustomer(Customer cus)
        {
            data.Remove(cus);
        }
    }
}
