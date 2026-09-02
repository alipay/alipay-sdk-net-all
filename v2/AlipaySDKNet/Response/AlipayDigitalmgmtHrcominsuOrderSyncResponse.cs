using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDigitalmgmtHrcominsuOrderSyncResponse.
    /// </summary>
    public class AlipayDigitalmgmtHrcominsuOrderSyncResponse : AopResponse
    {
        /// <summary>
        /// 家空间统一订单号（并发冲突时为空，调用方可重试）
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }
    }
}
