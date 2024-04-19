using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenCloudAppQueryResponse.
    /// </summary>
    public class AlipayOpenCloudAppQueryResponse : AopResponse
    {
        /// <summary>
        /// 云调用状态
        /// </summary>
        [XmlElement("cloud_call_status")]
        public string CloudCallStatus { get; set; }
    }
}
