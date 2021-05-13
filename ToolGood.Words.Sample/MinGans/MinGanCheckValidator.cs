using System;
using System.ComponentModel.DataAnnotations;

namespace ToolGood.Words.Sample.MinGans
{
    public class MinGanCheckValidator : IMinGanCheckValidator
    {
        public ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is string v)
            {
                if (!String.IsNullOrEmpty(v))
                {
                    if (MinGanProvider.Instance.IllegalWordsSearch.ContainsAny(v))
                    {
                        return new ValidationResult("存在敏感词", new[] { validationContext.MemberName });
                    }
                    // 检查拼音
                    if (MinGanProvider.Instance.IllegalWordsSearch.ContainsAny(WordsHelper.GetPinyin(v)))
                    {
                        return new ValidationResult("存在敏感词",new []{ validationContext.MemberName });
                    }
                    // todo:其他变种
                }
            }
            return ValidationResult.Success;
        }
    }
}