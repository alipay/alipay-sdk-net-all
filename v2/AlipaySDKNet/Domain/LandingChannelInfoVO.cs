using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LandingChannelInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class LandingChannelInfoVO : AopObject
    {
        /// <summary>
        /// 是否来自闪租频道，标记为联营，值为Y/N
        /// </summary>
        [XmlElement("union_rent_tag")]
        public string UnionRentTag { get; set; }
    }
}
