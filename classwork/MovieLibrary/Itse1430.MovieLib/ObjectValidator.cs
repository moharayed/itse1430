﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itse1430.MovieLib
{
    public static class ObjectValidator
    {
        public static IEnumerable<ValidationResult> TryValidateObject ( IValidatableObject value )
        {
            var results = new List<ValidationResult> ();

            var context = new ValidationContext (value);
            Validator.TryValidateObject (value, context, results, true);

            foreach (var result in results)
                yield return result;
        }
    }
}

//Static def =
//1) no 'this'
//2) no instance members

//Caller = 
//1) no instance
