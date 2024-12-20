using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalInsuranceDiffrecoveryPayModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalInsuranceDiffrecoveryPayModel : AopObject
    {
        /// <summary>
        /// 标识一次垫付申请，最近一次的垫付申请。
        /// </summary>
        [XmlElement("advance_apply_no")]
        public string AdvanceApplyNo { get; set; }

        /// <summary>
        /// 业务类型， 1-快赔追偿 2-欠款追偿
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部交易流水号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 标识垫资方的身份来源，支付宝定义的枚举值，对应到具体的垫资调用方
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 直赔场景的差额代扣发起订单标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 追偿总金额，单位为元，精确到小数点后两位，取值范围[0.01,99999999.99]
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
