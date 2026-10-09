using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GroupAccountVO Data Structure.
    /// </summary>
    [Serializable]
    public class GroupAccountVO : AopObject
    {
        /// <summary>
        /// 商业主体类型
        /// </summary>
        [XmlElement("biz_entity_type")]
        public string BizEntityType { get; set; }

        /// <summary>
        /// 收款账号
        /// </summary>
        [XmlElement("collect_account_no")]
        public string CollectAccountNo { get; set; }

        /// <summary>
        /// 范围类型。直连账号：PID，间连账号：SMID。
        /// </summary>
        [XmlElement("scope_item")]
        public string ScopeItem { get; set; }
    }
}
