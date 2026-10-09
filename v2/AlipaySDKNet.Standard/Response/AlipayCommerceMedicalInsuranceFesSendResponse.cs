using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalInsuranceFesSendResponse.
    /// </summary>
    public class AlipayCommerceMedicalInsuranceFesSendResponse : AopResponse
    {
        /// <summary>
        /// 交易时间
        /// </summary>
        [XmlElement("enc_content")]
        public string EncContent { get; set; }
    }
}
