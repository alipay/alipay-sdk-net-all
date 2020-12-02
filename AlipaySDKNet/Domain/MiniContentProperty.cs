using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MiniContentProperty Data Structure.
    /// </summary>
    [Serializable]
    public class MiniContentProperty : AopObject
    {
        /// <summary>
        /// 属性key，必须是平台预先定义的，否则不允许录入
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 属性状态，VALID：有效，INVALID：无效，MAN_AUDITING：审核中，MAN_AUDIT_REJECT：审核驳回
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 属性值
        /// </summary>
        [XmlArray("value_list")]
        [XmlArrayItem("string")]
        public List<string> ValueList { get; set; }
    }
}
