using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundWalletDepositorderCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundWalletDepositorderCreateModel : AopObject
    {
        /// <summary>
        /// 充值的本金金额，单位：元（人民币）
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
        /// 充值的膨胀金额，单位：元（人民币）
        /// </summary>
        [XmlElement("expand_amount")]
        public string ExpandAmount { get; set; }

        /// <summary>
        /// 会展示在用户个人消费记录备注，默认为专属钱包充值
        /// </summary>
        [XmlElement("order_title")]
        public string OrderTitle { get; set; }

        /// <summary>
        /// 充值外部订单号，由客户自己定义，用于幂等
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
        /// 销售产品码，接入时由产品定义
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 会展示在用户个人消费记录备注，默认为专属钱包充值
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 订单失效时间。绝对超时时间，格式为yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("time_expire")]
        public string TimeExpire { get; set; }

        /// <summary>
        /// 用户开通钱包时返回的钱包id
        /// </summary>
        [XmlElement("user_wallet_id")]
        public string UserWalletId { get; set; }

        /// <summary>
        /// 膨胀金的生效结束日期
        /// </summary>
        [XmlElement("valid_date")]
        public string ValidDate { get; set; }

        /// <summary>
        /// 需要家宴的用户主体信息
        /// </summary>
        [XmlArray("validate_user_principal_list")]
        [XmlArrayItem("validate_user_principal")]
        public List<ValidateUserPrincipal> ValidateUserPrincipalList { get; set; }
    }
}
