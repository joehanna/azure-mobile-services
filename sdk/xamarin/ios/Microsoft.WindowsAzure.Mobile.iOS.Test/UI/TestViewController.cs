using System;
using System.Linq;
using Microsoft.WindowsAzure.MobileServices.TestFramework;
using MonoTouch.UIKit;
using MonoTouch.Dialog;

namespace Microsoft.WindowsAzure.Mobile.Test
{
    public class TestViewController
        : DialogViewController
    {
        public TestViewController (TestMethod test, string log)
            : base (UITableViewStyle.Grouped, null, pushing: true)
        {
            var section = new Section();

            if (!String.IsNullOrWhiteSpace (test.Description))
                section.Add (new StyledMultilineElement ("Description:", test.Description));

            section.Add (new StyledMultilineElement ("Output:", log, UITableViewCellStyle.Subtitle));

            Root = new RootElement (test.Name) {
                section
            };
        }
    }
}