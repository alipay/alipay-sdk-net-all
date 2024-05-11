using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceAcommunicationCrowdMatchModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceAcommunicationCrowdMatchModel : AopObject
    {
        /// <summary>
        /// 运营商行业定义的人群ID，运营商行业给出
        /// </summary>
        [XmlArray("crowd_id")]
        [XmlArrayItem("string")]
        public List<string> CrowdId { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
