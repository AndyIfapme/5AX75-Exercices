using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp_02.Domain;
using WebApp_02.Infractructure;

namespace WebApp_02.Pages
{
    public class ContactModel : PageModel
    {
        private readonly DataContext _dataContext;

        [BindProperty]
        public ContactView Contact { get; set; }

        public ContactModel(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void OnGet()
        {

        }

        public void OnPost()
        {
            if (ModelState.IsValid)
            {
                //var text = JsonSerializer.Serialize(Contact);
                //System.IO.File.AppendAllText("contact.json", text);

                _dataContext.Set<Contact>().Add(new Contact
                {
                    Subject = Contact.Subject,
                    Email = Contact.Email,
                    Message = Contact.Message
                });

                _dataContext.SaveChanges();
            }
        }
    }

    public class ContactView
    {
        [Required(ErrorMessage = "L'adresse email est requise."), StringLength(128, ErrorMessage = "L'email ne peut pas dépasser 128 caractères")]
        public string Email { get; set; } = default!;

        [Required, StringLength(128)]
        public string Subject { get; set; } = default!;

        [Required, StringLength(512)]
        public string Message { get; set; } = default!;
    }
}
