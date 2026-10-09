using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportIndustryDataSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportIndustryDataSyncModel : AopObject
    {
        /// <summary>
        /// 数据请求体，不包含用户信息。
        /// </summary>
        [XmlElement("sync_content")]
        public string SyncContent { get; set; }

        /// <summary>
        /// 数据同步事件类型
        /// </summary>
        [XmlElement("sync_event")]
        public string SyncEvent { get; set; }

        /// <summary>
        /// 数据请求场景
        /// </summary>
        [XmlElement("sync_scene")]
        public string SyncScene { get; set; }

        /// <summary>
        /// 支持商户接入此业务的系统服务商id
        /// </summary>
        [XmlElement("sys_service_provider_id")]
        public string SysServiceProviderId { get; set; }
    }
}
