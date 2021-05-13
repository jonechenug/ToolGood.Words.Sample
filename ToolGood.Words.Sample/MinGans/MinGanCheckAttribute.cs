using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.Extensions.DependencyInjection;

namespace ToolGood.Words.Sample.MinGans
{
    /// <summary>
    /// 敏感词检查的特性，一匹配就抛异常
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class MinGanCheck : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            return validationContext.GetService<IMinGanCheckValidator>().IsValid(value, validationContext);
        }
    }
 
    /// <summary>
    /// 敏感词替换
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class MinGanReplace : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            validationContext.GetService<IMinGanReplaceValidator>().Replace(value, validationContext);
            return ValidationResult.Success;
        }
    }
}