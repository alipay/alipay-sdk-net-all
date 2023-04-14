using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTerminalPowerbankCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTerminalPowerbankCreateModel : AopObject
    {
        /// <summary>
        /// 地址位置纬度，使用国标GCJ-02坐标系，取值范围：纬度-90~90，中国地区经度范围：纬度3.86~53.55
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 地址位置经度，使用国标GCJ-02坐标系，取值范围：经度-180~180，中国地区经度范围：73.66~135.05
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 代理商在支付宝的pid
        /// </summary>
        [XmlElement("proxy_id")]
        public string ProxyId { get; set; }

        /// <summary>
        /// 终端设备的序列号
        /// </summary>
        [XmlElement("sn")]
        public string Sn { get; set; }
    }
}
