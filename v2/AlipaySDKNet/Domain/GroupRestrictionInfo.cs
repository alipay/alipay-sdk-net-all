using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GroupRestrictionInfo Data Structure.
    /// </summary>
    [Serializable]
    public class GroupRestrictionInfo : AopObject
    {
        /// <summary>
        /// 商品该做法最大选择份数
        /// </summary>
        [XmlElement("max")]
        public long Max { get; set; }

        /// <summary>
        /// 商品该做法最少选择份数
        /// </summary>
        [XmlElement("min")]
        public long Min { get; set; }
    }
}
