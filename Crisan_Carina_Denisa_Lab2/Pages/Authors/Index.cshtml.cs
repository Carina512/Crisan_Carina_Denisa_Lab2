﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Crisan_Carina_Denisa_Lab2.Data;
using Crisan_Carina_Denisa_Lab2.Models;

namespace Crisan_Carina_Denisa_Lab2.Pages.Authors
{
    public class IndexModel : PageModel
    {
        private readonly Crisan_Carina_Denisa_Lab2.Data.Crisan_Carina_Denisa_Lab2Context _context;

        public IndexModel(Crisan_Carina_Denisa_Lab2.Data.Crisan_Carina_Denisa_Lab2Context context)
        {
            _context = context;
        }

        public IList<Author> Author { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Author != null)
            {
                Author = await _context.Author.ToListAsync();
            }
        }
    }
}