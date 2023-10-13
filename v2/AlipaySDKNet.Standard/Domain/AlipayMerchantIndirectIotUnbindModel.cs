using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantIndirectIotUnbindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantIndirectIotUnbindModel : AopObject
    {
        /// <summary>
        /// 合约机和lite接入模式传设备SN号，千里传音模式传设备deviceName
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 固定枚举值（千里传音：ALIYUN，合约机：SDK，lite模式：LITE）
        /// </summary>
        [XmlElement("mode")]
        public string Mode { get; set; }

        /// <summary>
        /// 间连商户在支付宝体系内的唯一id,一般以2088开头
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }

        /// <summary>
        /// 合约机模式必传设备sourceId号，千里传音模式必传设备的productKey，lite模式必传分配给服务商的设备型号编码
        /// </summary>
        [XmlElement("supplier_id")]
        public string SupplierId { get; set; }
    }
}
