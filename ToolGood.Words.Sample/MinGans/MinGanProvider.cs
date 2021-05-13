using System;
using System.Collections.Generic;
using System.Linq;

namespace ToolGood.Words.Sample.MinGans
{
    public sealed class MinGanProvider
    {
        private static readonly Lazy<MinGanProvider>
            lazy =
                new Lazy<MinGanProvider>
                    (() => new MinGanProvider());

        public static MinGanProvider Instance { get { return lazy.Value; } }

        private MinGanProvider()
        {
            IllegalWordsSearch = new IllegalWordsSearch();
        }

        public readonly IllegalWordsSearch IllegalWordsSearch;


        public void SetKeys(List<string> keys)
        {
            if (keys!=null&&keys.Any())
            {
                var allKeys = new List<string>();
                foreach (var k in keys)
                {
                    allKeys.Add(k); // 增加词汇
                    allKeys.Add(WordsHelper.ToTraditionalChinese(k)); // 增加繁体
                    allKeys.Add(WordsHelper.GetPinyin(k)); // 增加拼音
                }
                IllegalWordsSearch.SetKeywords(allKeys);
            }
           
        }
    }
}