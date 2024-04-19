using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceCsccmngOpenapiTransferResponse.
    /// </summary>
    public class AlipayIserviceCsccmngOpenapiTransferResponse : AopResponse
    {
        /// <summary>
        /// 业务参数，业务执行是否成功和结果都从该参数中取
        /// </summary>
        [XmlElement("result_content")]
        public string ResultContent { get; set; }
    }
}
