using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainFinanceTvpAccountCloseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainFinanceTvpAccountCloseModel : AopObject
    {
        /// <summary>
        /// 账号
        /// </summary>
        [XmlElement("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 可信价值中心产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 申请流水，商户唯一
        /// </summary>
        [XmlElement("request_no")]
        public string RequestNo { get; set; }
    }
}
