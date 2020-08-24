using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPayApplepayTransactionBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPayApplepayTransactionBatchqueryModel : AopObject
    {
        /// <summary>
        /// 拉取结果权限authToken
        /// </summary>
        [XmlElement("authorization")]
        public string Authorization { get; set; }

        /// <summary>
        /// 设备id
        /// </summary>
        [XmlElement("device_identifier")]
        public string DeviceIdentifier { get; set; }

        /// <summary>
        /// 卡id
        /// </summary>
        [XmlElement("provisioning_bundle_identifier")]
        public string ProvisioningBundleIdentifier { get; set; }

        /// <summary>
        /// 毫秒级时间戳
        /// </summary>
        [XmlElement("tag")]
        public string Tag { get; set; }
    }
}
