using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalYpzConfigSyncResponse.
    /// </summary>
    public class AlipayCommerceMedicalYpzConfigSyncResponse : AopResponse
    {
        /// <summary>
        /// 返回值
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }
    }
}
