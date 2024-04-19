using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundWalletDestroyResponse.
    /// </summary>
    public class AlipayFundWalletDestroyResponse : AopResponse
    {
        /// <summary>
        /// 单位元，实际退款金额
        /// </summary>
        [XmlElement("actual_amount")]
        public string ActualAmount { get; set; }

        /// <summary>
        /// 单位元，金额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 销户单号
        /// </summary>
        [XmlElement("batch_bill_no")]
        public string BatchBillNo { get; set; }

        /// <summary>
        /// 钱包场景
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
