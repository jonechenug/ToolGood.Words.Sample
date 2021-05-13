using System.Collections.Generic;

namespace ToolGood.Words.Sample.MinGans
{
    public class MinGanKeys
    {
        /// <summary>
        /// 非法词语
        /// </summary>
        public List<string> IllegalKeywords { get; set; } = new List<string>();

        /// <summary>
        /// 非法网址
        /// </summary>
        public List<string> IllegalUrls { get; set; } = new List<string>();
    }
}