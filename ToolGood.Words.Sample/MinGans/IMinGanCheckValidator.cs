using System.ComponentModel.DataAnnotations;

namespace ToolGood.Words.Sample.MinGans
{
    public interface IMinGanCheckValidator
    {
        ValidationResult IsValid(object value, ValidationContext validationContext);
    }
}