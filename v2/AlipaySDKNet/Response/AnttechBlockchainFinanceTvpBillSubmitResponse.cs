using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainFinanceTvpBillSubmitResponse.
    /// </summary>
    public class AnttechBlockchainFinanceTvpBillSubmitResponse : AopResponse
    {
        /// <summary>
        /// 账单Id，数科唯一
        /// </summary>
        [XmlElement("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
