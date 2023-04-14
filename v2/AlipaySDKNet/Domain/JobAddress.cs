using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// JobAddress Data Structure.
    /// </summary>
    [Serializable]
    public class JobAddress : AopObject
    {
        /// <summary>
        /// 详细地址
        /// </summary>
        [XmlElement("detail")]
        public string Detail { get; set; }

        /// <summary>
        /// 高德坐标系经纬度，半角逗号分隔。
        /// </summary>
        [XmlElement("geo")]
        public string Geo { get; set; }

        /// <summary>
        /// 6位行政区域编码，具体到区(县)，如: 浙江省杭州市西湖区=330106。区域编码可参考：http://www.mca.gov.cn/article/sj/xzqh/1980/
        /// </summary>
        [XmlElement("region_code")]
        public string RegionCode { get; set; }
    }
}
