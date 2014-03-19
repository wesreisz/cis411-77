namespace PetStore_web.Migrations
{
    using PetStore_web.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PetStore_web.Models.PetDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PetStore_web.Models.PetDBContext context)
        {
            var person1 = new Person("Wes", "wes", "pass");
            var person2 = new Person("Kim", "kim", "pass");
            var person3 = new Person("Justin", "justin", "pass");
          
            context.Persons.Add(person1);
            context.Persons.Add(person2);
            context.Persons.Add(person3);
            
         var pet1 = new Pet
         {
             name = "German Shepard",
             description = "Bacon ipsum dolor sit amet shankle rump corned beef spare ribs bacon brisket sirloin landjaeger. Meatloaf chuck shankle pork belly hamburger kevin prosciutto, ground round strip steak andouille shank drumstick. Turkey pork chop capicola t-bone boudin pig bacon biltong rump porchetta. Hamburger ball tip shoulder sirloin shankle filet mignon andouille chicken. Pastrami strip steak drumstick jerky tongue.",
             lastUpdateDate = DateTime.Now,
             price=299.95,
             quantity=3,
             smlPicture = "http://upload.wikimedia.org/wikipedia/commons/thumb/5/51/DSHwiki.jpg/220px-DSHwiki.jpg",
             person = person1
         };
         var pet2 = new Pet
         {
             name = "Alley Cat",
             description = " brisket sirloin landjaeger. Meatloaf chuck shankle pork belly hamburger kevin prosciutto, ground round strip steak andouille shank drumstick. Turkey pork chop capicola t-bone boudin pig bacon biltong rump porchetta. Hamburger ball tip shoulder sirloin shankle filet mignon andouille chicken. Pastrami strip steak drumstick jerky tongue.",
             lastUpdateDate = DateTime.Now,
             price = 0.00,
             quantity = 3,
             smlPicture = "http://www.alleycat.org/view.image?Id=4112",
             person = person1
         };
         var pet3 = new Pet
         {
             name = "Goldfish",
             description = "Pastrami strip steak drumstick jerky tongue. Meatloaf chuck shankle pork belly hamburger brisket sirloin landjaeger. Meatloaf chuck shankle pork belly hamburger kevin prosciutto, ground round strip steak andouille shank drumstick. Turkey pork chop capicola t-bone boudin pig bacon biltong rump porchetta. Hamburger ball tip shoulder sirloin shankle filet mignon andouille chicken. Pastrami strip steak drumstick jerky tongue.",
             lastUpdateDate = DateTime.Now,
             price = 4.99,
             quantity = 32,
             smlPicture = "http://www.goldfish-as-pets.com/images/dreamstime_5422385cometgoldfish.jpg",
             person = person1
         };
         var pet4 = new Pet
         {
             name = "Ferret",
             description = " Meatloaf chuck shankle pork belly hamburger brisket sirloin landjaeger. Meatloaf chuck shankle pork belly hamburger kevin prosciutto, ground round strip steak andouille shank drumstick. Turkey pork chop capicola t-bone boudin pig bacon biltong rump porchetta. Hamburger ball tip shoulder sirloin shankle filet mignon andouille chicken. Pastrami strip steak drumstick jerky tongue.",
             lastUpdateDate = DateTime.Now,
             price = 10.00,
             quantity = 12,
             smlPicture = "http://www.backwaterreptiles.com/images/turtles/red-eared-slider-turtle-for-sale.jpg",
             person = person1
         };
         context.Pets.Add(pet1);
         context.Pets.Add(pet2);
         context.Pets.Add(pet3);
         context.Pets.Add(pet4);

         context.SaveChanges(); 
        }
    }
}
