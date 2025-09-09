using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceWithholdTaskCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceWithholdTaskCreateModel : AopObject
    {
        /// <summary>
        /// 代扣协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 扣款金额，单位为元
        /// </summary>
        [XmlElement("deduct")]
        public string Deduct { get; set; }

        /// <summary>
        /// 代扣任务结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识 当前字段已废弃(agreementNo本身带有uid信息)
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部业务号，用作幂等 当前字段已废弃(名称修改，不再使用该字段名参数)
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 支付宝用户的userId。 当前字段已废弃(agreementNo本身带有uid信息)
        /// </summary>
        [XmlElement("uid")]
        public string Uid { get; set; }
    }
}
