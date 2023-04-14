using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingDataDeerConnectorQueryResponse.
    /// </summary>
    public class AlipayMarketingDataDeerConnectorQueryResponse : AopResponse
    {
        /// <summary>
        /// 返回活动的流量数据
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }

        /// <summary>
        /// 请求业务处理是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
