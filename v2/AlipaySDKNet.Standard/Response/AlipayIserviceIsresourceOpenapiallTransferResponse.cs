using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceIsresourceOpenapiallTransferResponse.
    /// </summary>
    public class AlipayIserviceIsresourceOpenapiallTransferResponse : AopResponse
    {
        /// <summary>
        /// 序列化之后返回参数
        /// </summary>
        [XmlElement("biz_data")]
        public string BizData { get; set; }
    }
}
