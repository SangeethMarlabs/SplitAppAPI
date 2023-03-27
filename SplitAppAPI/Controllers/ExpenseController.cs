using Microsoft.AspNetCore.Mvc;
using SplitAppAPI.Models;
using SplitAppAPI.Services; 

namespace SplitAppAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExpenseController : Controller
    {
        private IExpenseService _expenseService;

        public ExpenseController(IExpenseService expenseService)
        {
            _expenseService = expenseService;
        }

        [HttpGet("GetAllExpCategories")]
        public IActionResult GetAllExpCategories()
        {
            var data = _expenseService.GetAllExpCategories();
            return Ok(data);
        }

        [HttpGet("GetAllExpenses")]
        public IActionResult GetAllExpenses()
        {
            var data = _expenseService.GetAllExpenses();
            return Ok(data);
        }

        [HttpPost("AddCategory")]
        public IActionResult AddCategory(Category category)
        {
            _expenseService.AddCategory(category);
            return Ok();
        }

        [HttpPost("AddExpense")]
        public IActionResult AddExpense(Expense expense)
        {
            _expenseService.AddExpense(expense);
            return Ok();
        }
    }
}
