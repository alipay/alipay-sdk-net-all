using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantMrchsurplmorderPreconsultResponse.
    /// </summary>
    public class AlipayMerchantMrchsurplmorderPreconsultResponse : AopResponse
    {
        /// <summary>
        /// 是否允许继续下单
        /// </summary>
        [XmlElement("allowed")]
        public bool Allowed { get; set; }

        /// <summary>
        /// 咨询不允许下单的原因的code
        /// </summary>
        [XmlElement("reason_code")]
        public string ReasonCode { get; set; }

        /// <summary>
        /// 如果不允许继续下单的原因是什么
        /// </summary>
        [XmlElement("reason_desc")]
        public string ReasonDesc { get; set; }
    }
}
