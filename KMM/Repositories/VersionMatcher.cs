using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KMM.Repositories
{
    public class VersionMatcher
    {
        private Version upper = null;
        private Version lower = null;
        // 0.13.0
        // 0.13.0 to 0.13.1
        public VersionMatcher(string expr)
        {
            // Ensure we won't get any weird stuff going on because some derpy user decided to use an uppercase T.
            expr = expr.ToLower();
            if (expr.Contains("to"))
            {
                // A range.
                // Split into two chunks.
                string[] chunks = expr.Split(new string[1] { "to" }, StringSplitOptions.None);
                // Start
                chunks[0] = chunks[0].Trim();
                if (chunks[0].Length == 0) throw new InvalidVersionException("The start of your KSP version range is empty");
                lower = new Version(chunks[0]);

                // End
                chunks[1] = chunks[1].Trim();
                if (chunks[1].Length == 0) throw new InvalidVersionException("The end of your KSP version range is empty");
                upper = new Version(chunks[1]);
            }
            else
            {
                expr = expr.Trim();
                if (expr.Length == 0) throw new InvalidVersionException("The KSP version is empty");
                lower = new Version(expr);
            }
        }

        // lower < CURRENT < upper
        public bool doesMatch(Version match)
        {
            if (upper != null)
            {
                if (lower >= match) return false;
                if (upper <= match) return false;
                return true;
            }
            else
            {
                return match == lower;
            }
        }
    }
}
