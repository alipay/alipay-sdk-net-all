using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZmepBiddingTargetInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ZmepBiddingTargetInfo : AopObject
    {
        /// <summary>
        /// 名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
