using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniAmpeDeviceSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniAmpeDeviceSyncModel : AopObject
    {
        /// <summary>
        /// 用于标识厂商单个设备产品下唯一的一个设备，推荐使用厂商自己定义的序列号。
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 设备产品的productId，由系统生成
        /// </summary>
        [XmlElement("product_id")]
        public string ProductId { get; set; }
    }
}
