﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebDiaryAPI.Data;
using WebDiaryAPI.Models;

namespace WebDiaryAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class DiaryEntriesController : ControllerBase
	{
		private readonly ApplicationDbContext _context;

		public DiaryEntriesController(ApplicationDbContext context)
		{
			_context = context;
		}

		[HttpGet]
		public async Task<ActionResult<IEnumerable<DiaryEntry>>> GetEntries()
		{
			return await _context.DiaryEntries.ToListAsync();
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<DiaryEntry>> GetById(int id)
		{
			//Database
			var diaryEntry = await _context.DiaryEntries.FindAsync(id);
			if (diaryEntry == null)
			{
				return NotFound();
			}
			return diaryEntry;
		}
	}
}
