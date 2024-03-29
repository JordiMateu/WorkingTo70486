﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OdeToFood.Models
{
	public class OdeToFoodDb: DbContext
	{
		public OdeToFoodDb(): base("DB")
		{
			
		}

		public DbSet<Restaurant> Restaurants { get; set; }
		public DbSet<RestaurantReview> RestaurantReviews { get; set; }

	    public void Dispose()
	    {
	        // Dispose of unmanaged resources.
	        Dispose(true);
	        // Suppress finalization.
	        GC.SuppressFinalize(this);
	    }
	}
}