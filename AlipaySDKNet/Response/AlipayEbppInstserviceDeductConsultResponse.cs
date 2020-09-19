using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInstserviceDeductConsultResponse.
    /// </summary>
    public class AlipayEbppInstserviceDeductConsultResponse : AopResponse
    {
        /// <summary>
        /// true代表可签约，false代表不可签约
        /// </summary>
        [XmlElement("allow_sign")]
        public string AllowSign { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 扩展字段（JSON格式）
        /// </summary>
        [XmlElement("extend_field")]
        public string ExtendField { get; set; }

        /// <summary>
        /// 支付模式（PREPAID表示预付费，POSTPAID表示后付费）
        /// </summary>
        [XmlElement("pay_mode")]
        public string PayMode { get; set; }
    }
}
