using Microsoft.AspNetCore.Identity;


namespace backend.Data
{
	public class User : IdentityUser
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public DateTime DateJoined { get; set; }
    }
}

