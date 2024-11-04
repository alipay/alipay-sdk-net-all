using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainFinanceTvpAccountprogressQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainFinanceTvpAccountprogressQueryModel : AopObject
    {
        /// <summary>
        /// 可信价值中心产品码，由对接业务同学提供
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
