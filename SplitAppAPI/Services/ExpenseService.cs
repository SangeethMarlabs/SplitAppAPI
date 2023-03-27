using SplitAppAPI.Models;
using System.Collections.Generic;
using UserRegistration.EntityFramework;

namespace SplitAppAPI.Services
{
    public class ExpenseService : IExpenseService
    {
        private ApplicationDbContext _applicationDbContext;

        public ExpenseService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public void AddCategory(Category category)
        {
            _applicationDbContext.Add(category);
            _applicationDbContext.SaveChanges();
        }

        public void AddExpense(Expense expense)
        {
            _applicationDbContext.Add(expense);
            _applicationDbContext.SaveChanges();
        }

        public IEnumerable<Category> GetAllExpCategories()
        {
            return _applicationDbContext.Category;
        }

        public IEnumerable<Expense> GetAllExpenses()
        {
            return _applicationDbContext.Expense;
        }
    }
}
