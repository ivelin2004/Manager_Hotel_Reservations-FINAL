using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Manager_Hotel_Reservations.Data;
using Manager_Hotel_Reservations.Models;

namespace Manager_Hotel_Reservations.Controllers
{
    public class RoomsController : Controller
    {
        private readonly Manager_Hotel_ReservationsContext _context;

        public RoomsController(Manager_Hotel_ReservationsContext context)
        {
            _context = context;
        }

        // GET: Rooms
        public async Task<IActionResult> Index()
        {
              return _context.Rooms_1 != null ? 
                          View(await _context.Rooms_1.ToListAsync()) :
                          Problem("Entity set 'Manager_Hotel_ReservationsContext.Rooms_1'  is null.");
        }

        // GET: Rooms/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Rooms_1 == null)
            {
                return NotFound();
            }

            var rooms = await _context.Rooms_1
                .FirstOrDefaultAsync(m => m.Id == id);
            if (rooms == null)
            {
                return NotFound();
            }

            return View(rooms);
        }

        // GET: Rooms/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Rooms/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Capacity,RoomType,IsFree,PricePerOccupiedBedAdult,PricePerOccupiedBedChildren,Number,Id")] Rooms rooms)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rooms);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(rooms);
        }

        // GET: Rooms/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Rooms_1 == null)
            {
                return NotFound();
            }

            var rooms = await _context.Rooms_1.FindAsync(id);
            if (rooms == null)
            {
                return NotFound();
            }
            return View(rooms);
        }

        // POST: Rooms/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Capacity,RoomType,IsFree,PricePerOccupiedBedAdult,PricePerOccupiedBedChildren,Number,Id")] Rooms rooms)
        {
            if (id != rooms.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rooms);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RoomsExists(rooms.Id))
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
            return View(rooms);
        }

        // GET: Rooms/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Rooms_1 == null)
            {
                return NotFound();
            }

            var rooms = await _context.Rooms_1
                .FirstOrDefaultAsync(m => m.Id == id);
            if (rooms == null)
            {
                return NotFound();
            }

            return View(rooms);
        }

        // POST: Rooms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Rooms_1 == null)
            {
                return Problem("Entity set 'Manager_Hotel_ReservationsContext.Rooms_1'  is null.");
            }
            var rooms = await _context.Rooms_1.FindAsync(id);
            if (rooms != null)
            {
                _context.Rooms_1.Remove(rooms);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RoomsExists(int id)
        {
          return (_context.Rooms_1?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
