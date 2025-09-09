using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainFinanceTvpBillCancelResponse.
    /// </summary>
    public class AnttechBlockchainFinanceTvpBillCancelResponse : AopResponse
    {
        /// <summary>
        /// 账单状态。 撤销成功返回 CLOSED。 已申请撤销但结果未确认，返回CLOSING。
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
