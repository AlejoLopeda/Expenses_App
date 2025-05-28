using Microsoft.AspNetCore.Mvc;
using Services.Dtos;
using Services.IServices;

public class ExpenseController : Controller
{
    private readonly IService service;

    public ExpenseController(IService s)
    {
        service = s;
    }

    [HttpGet]
    public IActionResult AddExpense()
    {
        return View(new ExpenseModel());
    }

    [HttpPost]
    public async Task<IActionResult> AddExpense(ExpenseModel model)
    {
        if (!ModelState.IsValid)
            return View(model);

        await service.AddExpense(model);
        return RedirectToAction("ExpenseList");
    }

    [HttpGet]
    public async Task<IActionResult> ExpenseList()
    {
        var expenses = await service.GetAllExpenses();
        return View(expenses);
    }
}