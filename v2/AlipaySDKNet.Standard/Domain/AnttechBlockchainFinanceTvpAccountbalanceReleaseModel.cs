using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainFinanceTvpAccountbalanceReleaseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainFinanceTvpAccountbalanceReleaseModel : AopObject
    {
        /// <summary>
        /// 账号
        /// </summary>
        [XmlElement("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 释放金额，单位元
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 申请流水
        /// </summary>
        [XmlElement("request_no")]
        public string RequestNo { get; set; }
    }
}
