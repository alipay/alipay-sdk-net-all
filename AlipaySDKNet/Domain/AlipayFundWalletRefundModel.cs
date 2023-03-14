using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundWalletRefundModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundWalletRefundModel : AopObject
    {
        /// <summary>
        /// 金额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 业务场景
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 原充值单号
        /// </summary>
        [XmlElement("original_deposit_order_id")]
        public string OriginalDepositOrderId { get; set; }

        /// <summary>
        /// 用户唯一请求标识
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 用户唯一表示
        /// </summary>
        [XmlElement("principal_id")]
        public string PrincipalId { get; set; }

        /// <summary>
        /// 用户唯一表示
        /// </summary>
        [XmlElement("principal_open_id")]
        public string PrincipalOpenId { get; set; }

        /// <summary>
        /// alipay_user_id代表支付宝用户id mechant_user_id代表商户id
        /// </summary>
        [XmlElement("principal_type")]
        public string PrincipalType { get; set; }

        /// <summary>
        /// 销售产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 提现策略
        /// </summary>
        [XmlElement("refund_strategy")]
        public string RefundStrategy { get; set; }

        /// <summary>
        /// 钱包id
        /// </summary>
        [XmlElement("user_wallet_id")]
        public string UserWalletId { get; set; }
    }
}
