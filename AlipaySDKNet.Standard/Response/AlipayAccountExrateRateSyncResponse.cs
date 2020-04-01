using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayAccountExrateRateSyncResponse.
    /// </summary>
    public class AlipayAccountExrateRateSyncResponse : AopResponse
    {
        /// <summary>
        /// 主站openapi通用接口操作返回结果
        /// </summary>
        [XmlElement("result_context")]
        public string ResultContext { get; set; }
    }
}
