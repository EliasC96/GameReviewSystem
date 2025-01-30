using GameReviewSystem.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
namespace GameReviewSystem.Pages.Games

{

    public class CreateModel : PageModel
    {
        private readonly GameReviewSystem.Data.GameReviewSystemContext _context;

        public CreateModel(GameReviewSystem.Data.GameReviewSystemContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Game Game { get; set; }

        [BindProperty]
        [NotMapped]

        public List<int> SelectedPlatformIds { get; set; }


        public List<Platform> Platforms { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            Platforms = await _context.Platform.ToListAsync();
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page(); 
            }

            // Add the new game to the database
            _context.Game.Add(Game);
            await _context.SaveChangesAsync(); 

           
            if (SelectedPlatformIds != null && SelectedPlatformIds.Count > 0)
            {
                foreach (var platformId in SelectedPlatformIds)
                {
                    var gamePlatform = new GamePlatform
                    {
                        GameId = Game.GameId, 
                        PlatformId = platformId
                    };
                    _context.GamePlatform.Add(gamePlatform); 
                }
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index"); 
        }
    }
}