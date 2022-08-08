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
        /// 充值的膨胀金额
        /// </summary>
        [XmlElement("expand_amount")]
        public string ExpandAmount { get; set; }

        /// <summary>
        /// 标题
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
        /// 销售产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 订单 有效期
        /// </summary>
        [XmlElement("time_expire")]
        public string TimeExpire { get; set; }
    }
}
