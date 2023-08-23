using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseWalletRefundhistoryQueryResponse.
    /// </summary>
    public class AlipayCloudCloudbaseWalletRefundhistoryQueryResponse : AopResponse
    {
        /// <summary>
        /// 提现记录列表
        /// </summary>
        [XmlArray("refund_histories")]
        [XmlArrayItem("refund_history")]
        public List<RefundHistory> RefundHistories { get; set; }
    }
}
