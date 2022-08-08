using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundWalletRefundResponse.
    /// </summary>
    public class AlipayFundWalletRefundResponse : AopResponse
    {
        /// <summary>
        /// 原路退实际退款金额
        /// </summary>
        [XmlElement("actual_amount")]
        public string ActualAmount { get; set; }

        /// <summary>
        /// 原路退金额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 原路退申请订单
        /// </summary>
        [XmlElement("batch_bill_no")]
        public string BatchBillNo { get; set; }

        /// <summary>
        /// 场景
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 用户钱包id
        /// </summary>
        [XmlElement("user_wallet_id")]
        public string UserWalletId { get; set; }
    }
}
