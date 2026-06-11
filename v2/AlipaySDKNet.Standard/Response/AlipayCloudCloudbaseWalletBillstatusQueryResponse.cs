using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseWalletBillstatusQueryResponse.
    /// </summary>
    public class AlipayCloudCloudbaseWalletBillstatusQueryResponse : AopResponse
    {
        /// <summary>
        /// 账单金额(分)
        /// </summary>
        [XmlElement("bill_amount")]
        public string BillAmount { get; set; }

        /// <summary>
        /// 原始账单金额(分)
        /// </summary>
        [XmlElement("origin_bill_amount")]
        public string OriginBillAmount { get; set; }

        /// <summary>
        /// 出账状态
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
