using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GameReviewSystem.Data;
using GameReviewSystem.Models;

namespace GameReviewSystem.Pages.Platforms
{
    public class DetailsModel : PageModel
    {
        private readonly GameReviewSystem.Data.GameReviewSystemContext _context;

        public DetailsModel(GameReviewSystem.Data.GameReviewSystemContext context)
        {
            _context = context;
        }

        public Platform Platform { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var platform = await _context.Platform.FirstOrDefaultAsync(m => m.PlatformId == id);
            if (platform == null)
            {
                return NotFound();
            }
            else
            {
                Platform = platform;
            }
            return Page();
        }
    }
}
