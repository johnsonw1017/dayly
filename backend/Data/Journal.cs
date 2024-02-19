using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Data
{
	public class Journal
	{
		public int Id { get; set; }
		public string? Title { get; set; }
		public string? Content { get; set; }
		[ForeignKey("UserId")]
		public User User { get; set; }
		public string UserId { get; set; }
		public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }

        public Journal()
		{
			Title = "Untitled";
		}
	}
}

