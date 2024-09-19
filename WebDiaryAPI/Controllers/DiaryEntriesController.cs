using Microsoft.AspNetCore.Http;
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

		[HttpPost]
		public async Task<ActionResult<DiaryEntry>> PostEntry(DiaryEntry diaryEntry)
		{
			diaryEntry.Id = 0;

			_context.DiaryEntries.Add(diaryEntry);

			await _context.SaveChangesAsync();

			var researceUrl = Url.Action(nameof(GetEntries), new {id = diaryEntry.Id});

			return Created("", diaryEntry);
		}

		// indicate that this action handles http put requests at
		// the url pattern "api/diaryentries/{id}"
		[HttpPut("{id}")]
		public async Task<IActionResult> PutEntry(int id, [FromBody] DiaryEntry diaryEntry)
		{
			if (id != diaryEntry.Id)
			{
				return BadRequest();
			}

			_context.Entry(diaryEntry).State = EntityState.Modified;

			try
			{
				await _context.SaveChangesAsync();
			}
			catch (DbUpdateConcurrencyException)
			{		
				if (!DiaryEntryExist(id))
				{
					return NotFound();
				}
				else
				{
					throw;
				}
			}
			return NoContent();			
		}

		private bool DiaryEntryExist(int id)
		{
			return _context.DiaryEntries.Any(e => e.Id == id); // for each element e
															   // check if the ID property of e
															   // is equal to our ID that we are
															   // passing.
		}

	}
}
