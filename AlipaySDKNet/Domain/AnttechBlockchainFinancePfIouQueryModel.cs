using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainFinancePfIouQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainFinancePfIouQueryModel : AopObject
    {
        /// <summary>
        /// 客户号
        /// </summary>
        [XmlElement("client_no")]
        public string ClientNo { get; set; }

        /// <summary>
        /// 借据号
        /// </summary>
        [XmlElement("debit_id")]
        public string DebitId { get; set; }

        /// <summary>
        /// 支用Id
        /// </summary>
        [XmlElement("financing_id")]
        public string FinancingId { get; set; }

        /// <summary>
        /// 个性化参数
        /// </summary>
        [XmlElement("parm")]
        public string Parm { get; set; }

        /// <summary>
        /// 平台Id
        /// </summary>
        [XmlElement("platform_id")]
        public string PlatformId { get; set; }
    }
}
