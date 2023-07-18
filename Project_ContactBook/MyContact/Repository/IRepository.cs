using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyContact.Repository
{
     interface IRepository
    {
        DataTable SelectAll();
        DataTable Search(string parameter);
        DataTable SelectRow(int contactID);
        bool Insert(string name, string family, string mobile, string email, int age, string address);
        bool Update(int contactID,string name, string family, string mobile, string email, int age, string address);
        bool Delete(int contactID);

    }
}
