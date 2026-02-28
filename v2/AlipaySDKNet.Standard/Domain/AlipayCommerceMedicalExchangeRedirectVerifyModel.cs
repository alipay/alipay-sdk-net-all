using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalExchangeRedirectVerifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalExchangeRedirectVerifyModel : AopObject
    {
        /// <summary>
        /// 会员卡权益ID
        /// </summary>
        [XmlElement("benefit_id")]
        public string BenefitId { get; set; }

        /// <summary>
        /// 用于同一请求的幂等校验
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 荣耀
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 兑换码
        /// </summary>
        [XmlElement("exchange_code")]
        public string ExchangeCode { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部开卡开始时间
        /// </summary>
        [XmlElement("out_service_start_time")]
        public string OutServiceStartTime { get; set; }

        /// <summary>
        /// 电话号码
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// true 是续费 false是非续费
        /// </summary>
        [XmlElement("renew")]
        public bool Renew { get; set; }

        /// <summary>
        /// 会员卡结束时间戳
        /// </summary>
        [XmlElement("service_end_time")]
        public string ServiceEndTime { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
