using System;
using System.Collections.Generic;
using System.Text;

namespace Ocelot.Configuration
{
    /// <summary>
    /// 安全选项类
    /// </summary>
    public class SecurityOptions
    {
        public SecurityOptions(List<string> allowedList, List<string> blockedList)
        {
            this.IPAllowedList = allowedList;
            this.IPBlockedList = blockedList;
        }

        //允许ip 列表
        public List<string> IPAllowedList { get; private set; }

        //禁止ip 列表
        public List<string> IPBlockedList { get; private set; }
    }
}
