using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RtaInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RtaInfo : AopObject
    {
        /// <summary>
        /// 广告投放账户id
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }
    }
}
