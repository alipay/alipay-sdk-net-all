using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineProviderCollaborateDevicebindUpdatecontextModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderCollaborateDevicebindUpdatecontextModel : AopObject
    {
        /// <summary>
        /// 发起操作的设备SN
        /// </summary>
        [XmlElement("device_sn")]
        public string DeviceSn { get; set; }

        /// <summary>
        /// 更新设备版本入参额外信息
        /// </summary>
        [XmlElement("ext_params")]
        public UpdateContentExtAttribute ExtParams { get; set; }
    }
}
