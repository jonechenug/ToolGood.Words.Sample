using System.ComponentModel.DataAnnotations;

namespace ToolGood.Words.Sample.MinGans
{
    public interface IMinGanReplaceValidator
    {
        void Replace(object value, ValidationContext validationContext);
    }
}