/*
 * Mohammed Rayed
 * Lab 5
 * ITSE 1430
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nile.Web.Models
{
    public static class NileModelExtensions
    {
        /// <summary>Converts a model to a product.</summary>
        /// <param name="source">The source.</param>
        /// <returns>The movie.</returns>
        public static Product ToDomain ( this NileModel source )
        {
            if (source == null)
                return null;

            return new Product () {
                Id = source.Id,
                Name = source.Name,
                Description = source.Description,
                Price = source.Price,
                IsDiscontinued = source.IsDiscontinued
            };
        }

        /// <summary>Converts a product to a model.</summary>
        /// <param name="source">The source.</param>
        /// <returns>The model.</returns>
        public static NileModel ToModel ( this Product source )
        {
            if (source == null)
                return null;

            return new NileModel () {
                Id = source.Id,
                Name = source.Name,
                Description = source.Description,
                Price = source.Price,
                IsDiscontinued = source.IsDiscontinued
            };
        }
    }

}