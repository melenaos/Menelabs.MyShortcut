using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShortcut.Library.Repository.Model
{
    public class GroupModel
    {
        public string Name { get; set; }

        /// <summary>
        /// The path that this group has been imported from.
        /// This might be out-of-synch anytime
        /// </summary>
        public string OriginalPath { get; set; }
        public bool IsAll { get; internal set; }
    }
}
