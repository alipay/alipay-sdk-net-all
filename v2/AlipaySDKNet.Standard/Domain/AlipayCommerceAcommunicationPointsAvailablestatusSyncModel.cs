using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceAcommunicationPointsAvailablestatusSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceAcommunicationPointsAvailablestatusSyncModel : AopObject
    {
        /// <summary>
        /// 运营商名称
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 省份
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }

        /// <summary>
        /// 积分可兑换状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
