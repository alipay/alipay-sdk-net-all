using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalHdfRecipeinfoSendResponse.
    /// </summary>
    public class AlipayCommerceMedicalHdfRecipeinfoSendResponse : AopResponse
    {
        /// <summary>
        /// 返回内容
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }
    }
}
