using ToolGood.Words.Sample.MinGans;

namespace ToolGood.Words.Sample.Controllers
{
    public class MinganCheckInput
    {
        [MinGanCheck]
        public string Text { get; set; }
    }
    
    public class MinganReplaceInput
    {
        [MinGanReplace]
        public string Text { get; set; }
    }
}