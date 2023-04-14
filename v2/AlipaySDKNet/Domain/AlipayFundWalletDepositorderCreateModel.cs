using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundWalletDepositorderCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundWalletDepositorderCreateModel : AopObject
    {
        /// <summary>
        /// 充值的本金金额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 业务场景
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 膨胀金的生效开始日期
        /// </summary>
        [XmlElement("effective_end_date")]
        public string EffectiveEndDate { get; set; }

        /// <summary>
        /// 充值的膨胀金额
        /// </summary>
        [XmlElement("expand_amount")]
        public string ExpandAmount { get; set; }

        /// <summary>
        /// 会展示在用户个人消费记录备注，默认为专属钱包充值
        /// </summary>
        [XmlElement("order_title")]
        public string OrderTitle { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 收款方信息，包括收款方id、收款方type、扩展信息
        /// </summary>
        [XmlElement("payee_info")]
        public ParticipantForm PayeeInfo { get; set; }

        /// <summary>
        /// 如何是app充值使用mobile 如果是pc充值使用PC
        /// </summary>
        [XmlElement("platform")]
        public string Platform { get; set; }

        /// <summary>
        /// 销售产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 会展示在用户个人消费记录备注，默认为专属钱包充值
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 订单 有效期
        /// </summary>
        [XmlElement("time_expire")]
        public string TimeExpire { get; set; }

        /// <summary>
        /// 钱包id
        /// </summary>
        [XmlElement("user_wallet_id")]
        public string UserWalletId { get; set; }

        /// <summary>
        /// 膨胀金的生效结束日期
        /// </summary>
        [XmlElement("valid_date")]
        public string ValidDate { get; set; }
    }
}
