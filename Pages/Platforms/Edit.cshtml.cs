using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GameReviewSystem.Data;
using GameReviewSystem.Models;

namespace GameReviewSystem.Pages.Platforms
{
    public class EditModel : PageModel
    {
        private readonly GameReviewSystem.Data.GameReviewSystemContext _context;

        public EditModel(GameReviewSystem.Data.GameReviewSystemContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Platform Platform { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var platform =  await _context.Platform.FirstOrDefaultAsync(m => m.PlatformId == id);
            if (platform == null)
            {
                return NotFound();
            }
            Platform = platform;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Platform).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PlatformExists(Platform.PlatformId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool PlatformExists(int id)
        {
            return _context.Platform.Any(e => e.PlatformId == id);
        }
    }
}
