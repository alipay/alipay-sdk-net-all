using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OrderTagInfo Data Structure.
    /// </summary>
    [Serializable]
    public class OrderTagInfo : AopObject
    {
        /// <summary>
        /// 是否禁止履约 空值：待履约（发货、发奖）
        /// </summary>
        [XmlElement("of_hold")]
        public string OfHold { get; set; }
    }
}
