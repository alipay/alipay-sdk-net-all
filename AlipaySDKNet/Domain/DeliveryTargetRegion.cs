using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeliveryTargetRegion Data Structure.
    /// </summary>
    [Serializable]
    public class DeliveryTargetRegion : AopObject
    {
        /// <summary>
        /// 区域编码，参考<a href="https://opendocs.alipay.com/pre-open/03144c" target="_blank">取值说明</a>
        /// </summary>
        [XmlElement("region_code")]
        public string RegionCode { get; set; }

        /// <summary>
        /// 区域名，参考<a href="https://opendocs.alipay.com/pre-open/03144c" target="_blank">取值说明</a>
        /// </summary>
        [XmlElement("region_name")]
        public string RegionName { get; set; }

        /// <summary>
        /// 区域类型，1代表全国，2代表省级区域，3代表市级区域，参考<a href="https://opendocs.alipay.com/pre-open/03144c" target="_blank">取值说明</a>
        /// </summary>
        [XmlElement("region_type")]
        public string RegionType { get; set; }
    }
}
