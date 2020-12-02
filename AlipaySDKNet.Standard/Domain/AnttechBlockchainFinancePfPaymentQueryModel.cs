using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainFinancePfPaymentQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainFinancePfPaymentQueryModel : AopObject
    {
        /// <summary>
        /// 业务参考号
        /// </summary>
        [XmlElement("buss_refr_no")]
        public string BussRefrNo { get; set; }

        /// <summary>
        /// 支用标识
        /// </summary>
        [XmlElement("financing_id")]
        public string FinancingId { get; set; }

        /// <summary>
        /// 平台标识
        /// </summary>
        [XmlElement("platform_id")]
        public string PlatformId { get; set; }
    }
}
