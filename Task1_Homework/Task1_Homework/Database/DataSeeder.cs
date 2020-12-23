﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task1_Homework.Business.Models;

namespace Task1_Homework.Business.Database
{
    public class DataSeeder
    {
        private readonly ResaleContext context;
        private readonly UserManager<User> userManager;
        private readonly RoleManager<IdentityRole> roleManager;

        private readonly List<Event> events = new List<Event>();

        private readonly List<Venue> venues = new List<Venue>();

        private readonly List<City> cities = new List<City>();

        private readonly List<Ticket> tickets = new List<Ticket>();

        private readonly List<Order> orders = new List<Order>();

        private readonly List<User> users = new List<User>();
        
        public DataSeeder(ResaleContext context, UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            this.context = context;
            this.userManager = userManager;
            this.roleManager = roleManager;
            
            users.AddRange(
                new []
                {
                    new User {UserName = "user1", Email = "user1@example.com"},
                    new User {UserName = "user2", Email = "user2@example.com"},
                    new User {UserName = "admin", Email = "admin@example.com"},
                });
            
            cities.AddRange(
                   new[]
                   {
                       new City { Name = "Minsk" , Country = "Belarus"},
                       new City { Name = "Moscow", Country = "Russia" },
                       new City { Name = "London", Country = "Great Britain" },
                       new City { Name = "New-York", Country = "USA" },
                       new City { Name = "Tokyo", Country = "Japan"},
                       new City { Name = "Homel", Country = "Belarus" },
                   });

            venues.AddRange(
                new[]
                {
                    new Venue { Name = "Prime Hall", Adress = "Somewhere in Minsk", City = cities[0] },
                    new Venue { Name = "Area 1.2", Adress = "Somewhere in Minsk", City = cities[0] },
                    new Venue { Name = "Area 2.1", Adress = "Somewhere in Moscow", City = cities[1] },
                    new Venue { Name = "Area 2.2", Adress = "Somewhere in Moscow", City = cities[1] },
                    new Venue { Name = "Area 3.1", Adress = "Somewhere in London", City = cities[2] },
                    new Venue { Name = "Area 3.2", Adress = "Somewhere in London", City = cities[2] },
                    new Venue { Name = "Area 4.1", Adress = "Somewhere in New-York", City = cities[3] },
                    new Venue { Name = "Area 4.2", Adress = "Somewhere in New-York", City = cities[3] },
                    new Venue { Name = "Area 5.1", Adress = "Somewhere in Tokyo", City = cities[4] },
                    new Venue { Name = "Area 5.2", Adress = "Somewhere in Tokyo", City = cities[4] },
                    new Venue { Name = "Area 6.1", Adress = "Somewhere in Homel", City = cities[5] },
                    new Venue { Name = "Area 6.2", Adress = "Somewhere in Homel", City = cities[5] },
                });

            events.AddRange(
                  new[]
                  {
                        new Event {  Date = new DateTime(2020, 09, 10, 19, 0, 0), Name = "Rock Hits", Venue = venues[4], Banner = "1.jpg", Description = "Рок-Культура — явление молодежной субкультуры, возникшей в Великобритании и США в 60 х гг." +
                        " вокруг нового муз. стиля и выражающей нонконформистский пафос. “Рок это больше, чем просто музыка, это энергетич. центр новой культуры и молодежной революции”." },

                        new Event {  Date = new DateTime(2020, 09, 13, 18, 30, 0), Name = "Artur Pirozhok",Venue = venues[2], Banner = "2.jpeg", Description = "Алекса́ндр Влади́мирович Ре́вва (укр. Олександр Володимирович Ревва; род. " +
                        "10 сентября 1974, Донецк, Украинская ССР, СССР) — российский шоумен, комедийный актёр, телеведущий, певец. Бывший игрок команды КВН «Утомлённые солнцем». " +
                        "Резидент юмористического шоу «Comedy Club». Как певец выступает под псевдонимом Артур Пирожков."},

                        new Event {  Date = new DateTime(2020, 10, 29, 16, 0, 0), Name = "B-2", Venue = venues[9], Banner = "3.jpg", Description = "Би-2 — советская, белорусская и российская рок-группа, образованная в " +
                        "1988 году в Бобруйске. Основатели и бессменные участники — Шура Би-2 (гитара, вокал) и Лёва Би-2 (основной вокал). " +
                        "В состав команды также входят Андрей Звонков (гитара), Макс Лакмус (бас-гитара), Борис Лифшиц (ударные, перкуссия) и " +
                        "Ян Николенко (бэк-вокал, клавишные, флейта, перкуссия). В 2017 году Би-2 завершили работу " +
                        "над десятым студийным альбомом «Горизонт событий»." },

                        new Event {  Date = new DateTime(2020, 11, 14, 20, 0, 0), Name = "Rock Concert", Venue = venues[9], Banner = "4.jpg", Description = "Рок-Культура — явление молодежной субкультуры, возникшей в Великобритании и США в 60 х гг." +
                        " вокруг нового муз. стиля и выражающей нонконформистский пафос. “Рок это больше, чем просто музыка, это энергетич. центр новой культуры и молодежной революции”." },

                        new Event { Date = new DateTime(2020, 11, 28, 20, 10, 0), Name = "Ivan Dorn", Venue = venues[0], Banner = "5.jpg", Description = "Ива́н Алекса́ндрович Дорн (укр. Іва́н Олекса́ндрович Дорн; род. 17 октября 1988, Челябинск, РСФСР, СССР) — украинский певец, музыкант, " +
                        "автор песен, продюсер, диджей, актёр и телеведущий. " +
                        "Основатель и директор студии звукозаписи Masterskaya. Бывший участник группы «Пара нормальных»." },

                        new Event {Date = new DateTime(2020, 10, 21, 19, 30, 0), Name = "Ivan Abramov",Venue = venues[1], Banner = "6.jpg", Description = "Иван Абрамов – комик-интеллигент, музыкант, резидент шоу «Stand Up», бывший КВНщик (играл в команде МГИМО «Парапапарам»). " +
                        "Он много шутит о знаменитостях, политиках и повседневной жизни, и в каждом его стендапе есть музыкальная составляющая."},

                        new Event { Date = new DateTime(2020, 10, 29, 18, 0, 0), Name = "NoizeMc XVI", Venue = venues[2], Banner = "7.jpg", Description = "Ива́н Алекса́ндрович Алексе́ев, более известный под сценическим псевдонимом Noize MС" +
                        " — российский музыкант, рэп-рок-исполнитель. " },

                        new Event { Date = new DateTime(2020, 10, 28, 17, 0, 0), Name = "Poets Of The Fall", Venue = venues[3], Banner = "8.jpg", Description = "Poets of the Fall — финская рок-группа, записывающаяся на собственном лейбле «Insomniac». Она образовалась в Хельсинки в 2003 году из дуэта старых друзей:" +
                        " вокалиста Марко Сааресто и гитариста Олли Тукиайнена, а также клавишника и продюсера Маркуса Каарлонена." },

                        new Event {  Date = new DateTime(2020, 12, 29, 20, 30, 0), Name = "Nickelback", Venue = venues[7], Banner = "9.jpg", Description = "Nickelback — канадская альтернативная рок-группа, основанная в 1995 году в городе Ханна. " +
                        "Группа состоит из гитариста и вокалиста Чеда Крюгера; гитариста, клавишника и бэк-вокалиста Райана Пик; басиста Майка Крюгера и барабанщика Дэниеля Адэра. " },

                        new Event {  Date = new DateTime(2020, 11, 14, 20, 0, 0), Name = "Maks Korzh", Venue = venues[9], Banner = "10.jpg", Description = "Макс Корж - молодой музыкант из Минска, выходдец из тусовки MuSkool, " +
                        "с лёгкостью смешивающий в своём творчестве электронную музыку, рэп и задушевное пение." },
                  });

            tickets.AddRange(
                new[]
                {
                     new Ticket { Event = events[0], Price = 100, Seller = users[1] },
                     new Ticket { Event = events[1], Price = 110, Seller = users[1] },
                     new Ticket { Event = events[0], Price = 110, Seller = users[1] },
                     new Ticket { Event = events[1], Price = 120, Seller = users[1] },
                     new Ticket { Event = events[7], Price = 120, Seller = users[1] },
                     new Ticket { Event = events[3], Price = 220, Seller = users[1] },
                });
        }

        public async Task SeedDataAsync()
        {
            if (await roleManager.FindByNameAsync("Administrator") == null)
            {
                await roleManager.CreateAsync(new IdentityRole { Name = "Administrator" });
                await roleManager.CreateAsync(new IdentityRole { Name = "User" });

                await userManager.CreateAsync(users[0], "user");
                await userManager.AddToRoleAsync(users[0], "User");

                await userManager.CreateAsync(users[1], "user");
                await userManager.AddToRoleAsync(users[1], "User");

                await userManager.CreateAsync(users[2], "admin");
                await userManager.AddToRoleAsync(users[2], "Administrator");
            }

            if (!context.Events.Any())
            {
                await context.Events.AddRangeAsync(events);
            }

            if (!context.Cities.Any())
            {
                await context.Cities.AddRangeAsync(cities);
            }

            if (!context.Venues.Any())
            {
                await context.Venues.AddRangeAsync(venues);
            }

            if (!context.Tickets.Any())
            {
                await context.Tickets.AddRangeAsync(tickets);
            }

            if (!context.Orders.Any())
            {
                await context.Orders.AddRangeAsync(orders);
            }

            await context.SaveChangesAsync();
        }
    }
}  

