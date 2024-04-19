using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudFundWalletRefundResponse.
    /// </summary>
    public class AlipayCloudFundWalletRefundResponse : AopResponse
    {
        /// <summary>
        /// 原路退实际退款金额,单位元
        /// </summary>
        [XmlElement("actual_amount")]
        public string ActualAmount { get; set; }

        /// <summary>
        /// 原路退金额，单位元
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 原路退申请订单号
        /// </summary>
        [XmlElement("batch_bill_no")]
        public string BatchBillNo { get; set; }

        /// <summary>
        /// 钱包id
        /// </summary>
        [XmlElement("user_wallet_id")]
        public string UserWalletId { get; set; }
    }
}
