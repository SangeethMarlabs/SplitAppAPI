using SplitAppAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SplitAppAPI.Services
{
    public interface IExpenseService
    {
        IEnumerable<Category> GetAllExpCategories();
        IEnumerable<Expense> GetAllExpenses();
        void AddCategory(Category category);
        void AddExpense(Expense expense);
    }
}
