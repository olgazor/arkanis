﻿using System;
using System.Collections.Generic;
using Arkanis.Core.Entities;

namespace Arkanis.Services.Services
{
    public interface IProductService
    {
		int Create(string code, string name, string description,
				   int quantity, decimal unitPrice, int unitsInStock,
				   int unitsOrdered, string user);
		void Delete(int id);
		T Get<T>(string code, string name, Func<ProductEntity, T> mapper);
		IEnumerable<T> GetAll<T>(Func<IEnumerable<ProductEntity>, IEnumerable<T>> mapper);
		IEnumerable<T> Search<T>(string name, Func<IEnumerable<ProductEntity>, IEnumerable<T>> mapper);
    }
}