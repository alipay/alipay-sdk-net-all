using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RankingDetailInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RankingDetailInfo : AopObject
    {
        /// <summary>
        /// 积分值
        /// </summary>
        [XmlElement("point")]
        public long Point { get; set; }
    }
}
