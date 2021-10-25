using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfResourceString
{
    public class MainWindowViewModel
    {
        /// <summary>
        /// 「さようなら」メッセージ。
        /// 「Properties.Resources.GOODBYE」を参照。
        /// </summary>
        public string GoodBye { get; set; } = Properties.Resources.GOODBYE;
    }
}
