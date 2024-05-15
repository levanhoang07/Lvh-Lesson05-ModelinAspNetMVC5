using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lvh_Lab04_2.Models
{
    public interface ICustomerRepository
    {
        //khai báo phương thức lấy danh sách khách hàng
        IList<Customer> GetCustomers();
        //khai báo phương thức lấy khách hàng
        Customer GetCustomer(string customerId);
        //khai báo phương thức thêm khách hàng
        void AddCustomer(Customer cus);
        //khai báo phương thức cập nhật khách hàng
        void UpdateCustomer(Customer cus);
        //khai báo phương thức tìm kiếm khách hàng
        IList<Customer> SearchCustomer(string name);
        //khai báo phương thức xóa khách hàng
        void DeleteCustomer(Customer cus);
    }
}
