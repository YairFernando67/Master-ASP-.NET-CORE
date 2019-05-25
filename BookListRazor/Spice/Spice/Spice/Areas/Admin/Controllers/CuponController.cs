using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Spice.Data;
using Spice.Models;

namespace Spice.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CuponController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CuponController(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _db.Cupon.ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Cupon coupons)
        {
            if(ModelState.IsValid)
            {
                var files = HttpContext.Request.Form.Files;
                if(files.Count()>0)
                {
                    byte[] p1 = null;
                    using (var fs1 = files[0].OpenReadStream())
                    {
                        using (var ms1 = new MemoryStream())
                        {
                            fs1.CopyTo(ms1);
                            p1 = ms1.ToArray();
                        }
                    }
                    coupons.Picture = p1;
                }
                _db.Cupon.Add(coupons);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(coupons);
        }

        //GET Edit Coupon
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var coupon = await _db.Cupon.SingleOrDefaultAsync(m => m.Id == id);
            if (coupon == null)
            {
                return NotFound();
            }
            return View(coupon);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Cupon coupons)
        {
            if (coupons.Id == 0)
            {
                return NotFound();
            }

            var couponFromDb = await _db.Cupon.Where(c => c.Id == coupons.Id).FirstOrDefaultAsync();

            if (ModelState.IsValid)
            {
                var files = HttpContext.Request.Form.Files;
                if (files.Count > 0)
                {
                    byte[] p1 = null;
                    using (var fs1 = files[0].OpenReadStream())
                    {
                        using (var ms1 = new MemoryStream())
                        {
                            fs1.CopyTo(ms1);
                            p1 = ms1.ToArray();
                        }
                    }
                    couponFromDb.Picture = p1;
                }
                couponFromDb.MinimumAmount = coupons.MinimumAmount;
                couponFromDb.Name = coupons.Name;
                couponFromDb.Discount = coupons.Discount;
                couponFromDb.CupontType = coupons.CupontType;
                couponFromDb.isActive = coupons.isActive;

                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(coupons);
        }

        //GET Details Coupon
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var coupon = await _db.Cupon.SingleOrDefaultAsync(m => m.Id == id);
            if (coupon == null)
            {
                return NotFound();
            }
            return View(coupon);
        }

        //GET - DELETE
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var coupons = await _db.Cupon.FindAsync(id);
            if (coupons == null)
            {
                return NotFound();
            }

            return View(coupons);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            var coupon = await _db.Cupon.FindAsync(id);
            if (coupon == null)
            {
                return View();
            }
            _db.Cupon.Remove(coupon);

            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
} 
       
