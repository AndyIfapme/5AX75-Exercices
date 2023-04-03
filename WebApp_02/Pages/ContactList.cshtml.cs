using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApp_02.Domain;
using WebApp_02.Infractructure;

namespace WebApp_02.WebApp.Pages
{
    public class ContactListModel : PageModel
    {
        private readonly DataContext _dataContext;

        public List<ContactView> Contacts { get; set; }

        public ContactListModel (DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void OnGet()
        {
            Contacts = _dataContext.Set<Contact>()
                .Select(contact => new ContactView
                {
                    Subject = contact.Subject,
                    Email = contact.Email,
                    Message = contact.Message
                })
                .ToList();
        }

        public class ContactView
        {
            public string Email { get; set; } = default!;
            public string Subject { get; set; } = default!;
            public string Message { get; set; } = default!;
        }
    }
}
