using CrudAsp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace CrudAsp.Controllers
{
    public class AnimaisController : Controller
    {
        private readonly AnimaisContext _context;

        public AnimaisController(AnimaisContext context)
        {
            _context = context;
        }

        // GET: Animais
        public async Task<IActionResult> Animais()
        {
            return View(await _context.Animais.ToListAsync());
        }

        // GET: Animais/Create
        public IActionResult AdicionarOuEditar(int id = 0)
        {
            return View(new Animal());
        }

        // POST: Animal/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AdicionarOuEditar([Bind("AnimalId,Nome,Especie,Endereco,Raca")] Animal animal)
        {
            if (ModelState.IsValid)
            {
                _context.Add(animal);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Animais));
            }
            return View(animal);
        }


        // GET: Animais/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var animal = await _context.Animais
                .FirstOrDefaultAsync(m => m.AnimalId == id);
            if (animal == null)
            {
                return NotFound();
            }

            return View(animal);
        }

    }
}
