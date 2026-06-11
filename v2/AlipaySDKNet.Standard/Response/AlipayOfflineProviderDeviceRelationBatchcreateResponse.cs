using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineProviderDeviceRelationBatchcreateResponse.
    /// </summary>
    public class AlipayOfflineProviderDeviceRelationBatchcreateResponse : AopResponse
    {
        /// <summary>
        /// 新增设备数量
        /// </summary>
        [XmlElement("insert_count")]
        public long InsertCount { get; set; }

        /// <summary>
        /// 更新设备数量
        /// </summary>
        [XmlElement("update_count")]
        public long UpdateCount { get; set; }
    }
}
