using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiCateringDishCommruleSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringDishCommruleSyncModel : AopObject
    {
        /// <summary>
        /// 规则列表 可批量操作
        /// </summary>
        [XmlArray("kbdish_comm_rule_info_list")]
        [XmlArrayItem("kbdish_comm_rule_info")]
        public List<KbdishCommRuleInfo> KbdishCommRuleInfoList { get; set; }
    }
}
