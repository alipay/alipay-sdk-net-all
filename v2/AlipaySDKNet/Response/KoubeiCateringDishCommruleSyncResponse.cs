using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiCateringDishCommruleSyncResponse.
    /// </summary>
    public class KoubeiCateringDishCommruleSyncResponse : AopResponse
    {
        /// <summary>
        /// 新增返回的数据集合，如果是修改 或者删除 不返回
        /// </summary>
        [XmlArray("kbdish_comm_rule_info_list")]
        [XmlArrayItem("kbdish_comm_rule_info")]
        public List<KbdishCommRuleInfo> KbdishCommRuleInfoList { get; set; }
    }
}
