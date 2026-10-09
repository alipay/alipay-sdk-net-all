using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceIsresourceOpenapiTransferResponse.
    /// </summary>
    public class AlipayIserviceIsresourceOpenapiTransferResponse : AopResponse
    {
        /// <summary>
        /// facade接口的出参
        /// </summary>
        [XmlElement("biz_data")]
        public string BizData { get; set; }
    }
}
