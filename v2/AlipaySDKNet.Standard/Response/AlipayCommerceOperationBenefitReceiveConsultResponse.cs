using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceOperationBenefitReceiveConsultResponse.
    /// </summary>
    public class AlipayCommerceOperationBenefitReceiveConsultResponse : AopResponse
    {
        /// <summary>
        /// 咨询结果，true表示通过，false不通过
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }

        /// <summary>
        /// 咨询结果
        /// </summary>
        [XmlElement("result_desc")]
        public string ResultDesc { get; set; }
    }
}
