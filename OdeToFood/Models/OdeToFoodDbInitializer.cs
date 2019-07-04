using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OdeToFood.Models
{
	public class OdeToFoodDbInitializer : DropCreateDatabaseAlways<OdeToFoodDb>
	{
		protected override void Seed(OdeToFoodDb context)
		{
			GetRestaurants().ForEach(c => context.Restaurants.Add(c));
			context.SaveChanges();

			GetReviews().ForEach(d => context.RestaurantReviews.Add(d));
			context.SaveChanges();

			base.Seed(context);
		}

		private static List<Restaurant> GetRestaurants()
		{
			var restaurant = new List<Restaurant>
			{
				new Restaurant()
				{
					Id = 1,
					Name = "Can Punyetes",
					City = "Barcelona",
					Country = "Spain",
					Reviews = new List<RestaurantReview>()
				},
				new Restaurant()
				{
					Id = 2,
					Name = "SalSon",
					City = "Lleida",
					Country = "Spain",
					Reviews = new List<RestaurantReview>()
				},
				new Restaurant()
				{
					Id = 3,
					Name = "La Madame",
					City = "Girona",
					Country = "Spain",
					Reviews = new List<RestaurantReview>()
				},
				new Restaurant()
				{
					Id = 4,
					Name = "Cabezabola",
					City = "New York",
					Country = "Usa",
					Reviews = new List<RestaurantReview>()
				}
			};

			return restaurant;
		}

		private static List<RestaurantReview> GetReviews()
		{
			var reviews = new List<RestaurantReview>
			{
				new RestaurantReview()
				{
					Id = 1,
					RestaurantId = 1,
					Body = "Fuerte olor a orin",
					Rating = 2
				},
				new RestaurantReview()
				{
					Id = 2,
					RestaurantId = 1,
					Body = "Camarera hippie huele a sobaco total",
					Rating = 3
				},
				new RestaurantReview()
				{
					Id = 3,
					RestaurantId = 2,
					Body = "Que WCs más limpios. Volveré",
					Rating = 8
				},
				new RestaurantReview()
				{
					Id = 4,
					RestaurantId = 2,
					Body = "Camarero no conoce el Suajili. Falta de respeto",
					Rating = 2
				},
				new RestaurantReview()
				{
					Id = 5,
					RestaurantId = 3,
					Body = "Tardaron dos horas en servirnos",
					Rating = 1
				},
				new RestaurantReview()
				{
					Id = 5,
					RestaurantId = 3,
					Body = "Muy hipster.",
					Rating = 7
				},
				new RestaurantReview()
				{
					Id = 6,
					RestaurantId = 4,
					Body = "El cocinero es mi primo",
					Rating = 5
				}
			};

			return reviews;
		}
	}
}