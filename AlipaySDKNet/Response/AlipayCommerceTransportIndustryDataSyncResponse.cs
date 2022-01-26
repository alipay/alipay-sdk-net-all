using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportIndustryDataSyncResponse.
    /// </summary>
    public class AlipayCommerceTransportIndustryDataSyncResponse : AopResponse
    {
        /// <summary>
        /// 数据同步接口响应，根据请求场景、事件类型的变化而不同
        /// </summary>
        [XmlElement("sync_response")]
        public string SyncResponse { get; set; }
    }
}
