using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManager
{
    class TextReplacementRule
    {
        public TextReplacementRule(string textToReplace, Func<string> textToInsert, Func<bool> shouldReplace)
        {
            TextToReplace = textToReplace;
            TextToInsert = textToInsert;
            ShouldReplace = shouldReplace;
        }

        public TextReplacementRule(string textToReplace, Func<string> textToInsertTrue, Func<string> textToInsertFalse, Func<bool> shouldReplace) : this(textToReplace, shouldReplace() ? textToInsertTrue : textToInsertFalse)
        {
        }

        public TextReplacementRule(string textToReplace, Func<string> textToInsert) : this(textToReplace, textToInsert, () => true)
        {
        }

        public string TextToReplace { get; }

        public Func<string> TextToInsert { get; }

        public Func<bool> ShouldReplace { get; }
    }
}
