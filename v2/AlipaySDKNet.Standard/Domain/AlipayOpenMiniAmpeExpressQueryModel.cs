using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniAmpeExpressQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniAmpeExpressQueryModel : AopObject
    {
        /// <summary>
        /// 设备编号
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 设备产品id
        /// </summary>
        [XmlElement("product_id")]
        public long ProductId { get; set; }

        /// <summary>
        /// 从ampe获取的用户标识
        /// </summary>
        [XmlElement("user_key")]
        public string UserKey { get; set; }

        /// <summary>
        /// 用户路由标识，从ampe处获取
        /// </summary>
        [XmlElement("user_route")]
        public string UserRoute { get; set; }
    }
}
