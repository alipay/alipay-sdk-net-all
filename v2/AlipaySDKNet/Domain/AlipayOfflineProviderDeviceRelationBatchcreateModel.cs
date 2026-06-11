using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineProviderDeviceRelationBatchcreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderDeviceRelationBatchcreateModel : AopObject
    {
        /// <summary>
        /// 设备关联信息列表
        /// </summary>
        [XmlArray("device_relation_list")]
        [XmlArrayItem("device_relation_detail")]
        public List<DeviceRelationDetail> DeviceRelationList { get; set; }
    }
}
