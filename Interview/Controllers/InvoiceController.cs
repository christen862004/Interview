using Interview.Models;
using Interview.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Interview.Controllers
{
    public class InvoiceController : Controller
    {
        private readonly IGeneralRepository<InvoiceDetail> invoiceREpo;
        private readonly IGeneralRepository<Unit> unitRepo;

        public InvoiceController(IGeneralRepository<InvoiceDetail> InvoiceREpo,IGeneralRepository<Unit> UnitRepo)
        {
            invoiceREpo = InvoiceREpo;
            unitRepo = UnitRepo;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Getall()
        { 
            return View(await invoiceREpo.GetAll());
        }

        public async Task<IActionResult> New(int id)
        {
            List<Unit> units = await unitRepo.GetAll();
            ViewData["Units"] = units;
            if (id == 0)
            {
               
                return View();
            }
            else
            {
                InvoiceDetail invoice=( await invoiceREpo.GetAll()).FirstOrDefault(i=>i.LineNo== id);
                return View(invoice);
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> New(InvoiceDetail NewInvoice)
        {
            if (ModelState.IsValid)
            {
                invoiceREpo.Add(NewInvoice);
                return RedirectToAction("Getall");
            }
            List<Unit> units = await unitRepo.GetAll();
            ViewData["Units"] = units;
            return View(NewInvoice);
        }

    }
}
