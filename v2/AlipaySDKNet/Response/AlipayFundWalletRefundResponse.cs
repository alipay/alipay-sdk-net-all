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
        /// 实际退回给用户的金额。当钱包账户存在膨胀金等特殊情况时，实际退回给用户的金额等于发起金额扣减膨胀金额。单位为元
        /// </summary>
        [XmlElement("actual_amount")]
        public string ActualAmount { get; set; }

        /// <summary>
        /// 用户发起原路退的金额
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
