using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniAmpeUsersceneQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniAmpeUsersceneQueryModel : AopObject
    {
        /// <summary>
        /// 设备标识
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 产品id
        /// </summary>
        [XmlElement("product_id")]
        public long ProductId { get; set; }

        /// <summary>
        /// 通过ampe获取的用户标识
        /// </summary>
        [XmlElement("user_key")]
        public string UserKey { get; set; }
    }
}
