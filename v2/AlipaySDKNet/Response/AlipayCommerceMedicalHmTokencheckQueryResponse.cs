using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalHmTokencheckQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalHmTokencheckQueryResponse : AopResponse
    {
        /// <summary>
        /// 健管人员id, token有效的场景才会返回
        /// </summary>
        [XmlElement("hmuid")]
        public string Hmuid { get; set; }
    }
}
