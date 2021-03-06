﻿
using System;

namespace WebApplication1.Domain.Entities
{
	public class PostEntity
	{
		public int PostId { get; set; }
		public UserEntity User { get; set; }
		public string Title { get; set; }
		public string PostContent { get; set; }
		public string Price { get; set; }
		public string ImageUrl { get; set; }
		public DateTime Date { get; set; }
	}
}

