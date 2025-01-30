using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using GameReviewSystem.Data;
using GameReviewSystem.Models;

namespace GameReviewSystem.Pages.Platforms
{
    public class CreateModel : PageModel
    {
        private readonly GameReviewSystem.Data.GameReviewSystemContext _context;

        public CreateModel(GameReviewSystem.Data.GameReviewSystemContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Platform Platform { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Platform.Add(Platform);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
