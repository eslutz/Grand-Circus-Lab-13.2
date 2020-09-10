﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using Lab_13._2.Models;

namespace Lab_13._2.Controllers
{
	public class ProductsController : Controller
	{
		public IActionResult Index()
		{
			IDbConnection database = new SqlConnection("Server=BCKW433\\SQLEXPRESS;Database=CoffeeShop;user id=CoffeeShopUser;password=password");
			database.Open();
			List<Product> products = database.Query<Product>("select * from Product").AsList<Product>();
			database.Close();

			return View(products);
		}
	}
}
