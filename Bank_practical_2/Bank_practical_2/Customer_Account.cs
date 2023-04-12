using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_practical_2
{
    class Customer_Account
    {
        string bank_name = "SBI";
        long customer_accountNo;
        string customer_name;

        public Customer_Account(long acc_no, string c_name)
        {

            customer_accountNo = acc_no;
            customer_name = c_name;
        }

        /// <summary>
        /// This method  display  information about Customer account
        /// </summary>
        public string PrintInfo()
        {
            return ($"Bank Name: {bank_name}\nCustomer Name: {customer_name}\ncusomer Account no :  {customer_accountNo}");

        }
    }
}
