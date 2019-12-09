﻿/*
 * Mohammed Rayed
 * Lab 4
 * ITSE 1430
 */
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nile
{
    public static class ObjectValidator
    {
        public static IEnumerable<ValidationResult> TryValidateObject ( IValidatableObject value )
        {
            var results = new List<ValidationResult> ();

            var context = new ValidationContext (value);

            Validator.TryValidateObject (value, context, results);

            foreach (var result in results)
                yield return result;
        }
    }
}
