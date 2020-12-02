using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GrouponRule Data Structure.
    /// </summary>
    [Serializable]
    public class GrouponRule : AopObject
    {
        /// <summary>
        /// 拼团成团人数
        /// </summary>
        [XmlElement("group_size")]
        public string GroupSize { get; set; }

        /// <summary>
        /// 拼团价格，单位元
        /// </summary>
        [XmlElement("groupon_price")]
        public string GrouponPrice { get; set; }
    }
}
