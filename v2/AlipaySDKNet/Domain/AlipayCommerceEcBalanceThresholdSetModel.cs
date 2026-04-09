using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcBalanceThresholdSetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcBalanceThresholdSetModel : AopObject
    {
        /// <summary>
        /// 企业码企业ID
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 阀值金（分），不能低于 50000（500元）
        /// </summary>
        [XmlElement("threshold")]
        public long Threshold { get; set; }
    }
}
