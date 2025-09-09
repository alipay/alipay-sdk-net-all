using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalHdfAttachmentIdentifyResponse.
    /// </summary>
    public class AlipayCommerceMedicalHdfAttachmentIdentifyResponse : AopResponse
    {
        /// <summary>
        /// 返回的数据内容
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }
    }
}
