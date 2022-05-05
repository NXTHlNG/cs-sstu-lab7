#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using cs_sstu_lab7.Data;
using cs_sstu_lab7.Models;

namespace cs_sstu_lab7.Controllers
{
    public class PartyMembersController : Controller
    {
        private readonly PartyContext _context;

        public PartyMembersController(PartyContext context)
        {
            _context = context;
        }

        // GET: PartyMembers
        public async Task<IActionResult> Index()
        {
            return View(await _context.PartyMember.ToListAsync());
        }

        // GET: PartyMembers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var partyMember = await _context.PartyMember
                .FirstOrDefaultAsync(m => m.Id == id);
            if (partyMember == null)
            {
                return NotFound();
            }

            return View(partyMember);
        }

        // GET: PartyMembers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PartyMembers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Status")] PartyMember partyMember)
        {
            if (ModelState.IsValid)
            {
                _context.Add(partyMember);
                await _context.SaveChangesAsync();
                return RedirectToAction("Thanks", "Home"); ;
            }
            return View(partyMember);
        }

        // GET: PartyMembers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var partyMember = await _context.PartyMember.FindAsync(id);
            if (partyMember == null)
            {
                return NotFound();
            }
            return View(partyMember);
        }

        // POST: PartyMembers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Status")] PartyMember partyMember)
        {
            if (id != partyMember.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(partyMember);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PartyMemberExists(partyMember.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(partyMember);
        }

        // GET: PartyMembers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var partyMember = await _context.PartyMember
                .FirstOrDefaultAsync(m => m.Id == id);
            if (partyMember == null)
            {
                return NotFound();
            }

            return View(partyMember);
        }

        // POST: PartyMembers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var partyMember = await _context.PartyMember.FindAsync(id);
            _context.PartyMember.Remove(partyMember);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PartyMemberExists(int id)
        {
            return _context.PartyMember.Any(e => e.Id == id);
        }
    }
}
