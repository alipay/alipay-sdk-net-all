using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantIndirectIotbindQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantIndirectIotbindQueryModel : AopObject
    {
        /// <summary>
        /// 合约机和lite接入模式传设备SN号，千里传音接入模式传设备deviceName
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 固定枚举值（千里传音模式：ALIYUN，合约机模式：SDK，支音lite模式：LITE）
        /// </summary>
        [XmlElement("mode")]
        public string Mode { get; set; }

        /// <summary>
        /// 合约机模式必传设备sourceId号，千里传音模式必传设备的productKey，lite模式必传分配给服务商的设备型号编码
        /// </summary>
        [XmlElement("supplier_id")]
        public string SupplierId { get; set; }
    }
}
