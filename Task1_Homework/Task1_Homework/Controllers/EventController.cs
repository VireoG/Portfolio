﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task1_Homework.Models;
using Task1_Homework.Business;
using Task1_Homework.Business.Models;
using Microsoft.Extensions.Localization;
using Task1_Homework.Business.Database;
using Newtonsoft.Json;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Task1_Homework.Business.Services.IServices;

namespace Task1_Homework.Controllers
{
    public class EventController : Controller
    {
        private readonly IUserService userService;
        private readonly ITicketService ticketService;
        private readonly IEventService eventService;
        private readonly IVenueService venueService;
        private readonly ICityService cityService;

        public EventController(IUserService userService,ITicketService ticketService, IEventService eventService, IVenueService venueService, ICityService cityService)
        {
            this.userService = userService;
            this.ticketService = ticketService;
            this.eventService = eventService;
            this.venueService = venueService;
            this.cityService = cityService;
        }

         public IActionResult Index()
        {
            var ev = new EventsViewModel()
            {
                Cities = cityService.GetCities().ToArray(),
                Venues = venueService.GetVenues().ToArray()
            };

            if (User.Identity.Name != null)
            {
                ViewBag.UserRole = userService.GetUserRole(User.Identity.Name);
            }

            return View(ev);
        }

        public async Task<IActionResult> Buy([FromRoute] int? id)
        {
            if (id != null)
            {
                var events = eventService.GetEventById(id);

                events.Tickets = await ticketService.GetTicketsByEventIdForIdentityUser(id , User.Identity.Name);

                return View("Buy", events);
            }

            return NotFound();
        }

        [Authorize(Roles = "Administrator")]
        public IActionResult Edit(int? id)
        {
            if (id != null)
            {
                var venues = new SelectList(venueService.GetVenues(), "Id", "Name");
                ViewBag.Venues = venues;
                var ev = eventService.GetEventById(id);
                return View(ev);
            }
            return NotFound();
        }

        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public async Task<IActionResult> Edit(Event model)
        {
            if (ModelState.IsValid)
            {
                await eventService.EditSave(model);
                return RedirectToAction("Index");
            }

            return RedirectToAction("Edit");
        }

        [ActionName("Delete")]
        public IActionResult ConfirmDelete(int? id)
        {
            if (id != null)
            {
                var @event = eventService.GetEventById(id);
                return PartialView("_Delete", @event);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id != null)
            {
                var ev = eventService.GetEventById(id);
                if (ev != null)
                {
                    await eventService.Delete(ev);
                    return RedirectToAction("Index");
                }
            }
            return NotFound();
        }
    }
}
