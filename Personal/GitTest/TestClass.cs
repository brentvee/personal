/*¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯*\
  File Name: TestClass.cs
  Language:  C#
  Platform:  [x] .net
             [ ] Silverlight
  Company:   Inivit Systems
             This code and information is provided “as is” without warranty of 
             any kind, either expressed or implied.
  Author:    Brent van der Merwe
  Date:      2013-08-02 11:48 
  Purpose:	
    
  Updates:

	Reviews
\*____________________________________________________________________________*/

using System.Diagnostics;
using System.Linq;

namespace GitTest
{
    public class TestClass
    {
        public void Method1()
        {
            Enumerable.Range(1, 100)
                .Select(o => string.Format("{0}", o))
                .ToList()
                .ForEach(o => Debug.WriteLine(o));
        }
    }
}
