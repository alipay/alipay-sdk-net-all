using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalPaymentPreconsultResponse.
    /// </summary>
    public class AlipayCommerceMedicalPaymentPreconsultResponse : AopResponse
    {
        /// <summary>
        /// 建议的推进策略；商家可参考建议推进业务动作
        /// </summary>
        [XmlElement("suggestion")]
        public string Suggestion { get; set; }
    }
}
