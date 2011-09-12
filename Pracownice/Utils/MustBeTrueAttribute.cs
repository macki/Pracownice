using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System.Collections.Generic;

[AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
public class MustBeTrueAttribute : ValidationAttribute, IClientValidatable
{
    public override bool IsValid(object value)
    {
        return value != null && value is bool && (bool)value;
    }

    public IEnumerable<ModelClientValidationRule> GetClientValidationRules(ModelMetadata metadata, ControllerContext context)
    {
        yield return new ModelClientValidationRule
        {
            ErrorMessage = this.ErrorMessage,
            ValidationType = "mustbetrue"
        };
    }
}