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
        /// 地址名称
        /// </summary>
        [XmlElement("address_name")]
        public string AddressName { get; set; }

        /// <summary>
        /// 详细办公地址
        /// </summary>
        [XmlElement("detail")]
        public string Detail { get; set; }

        /// <summary>
        /// 高德坐标系经纬度 <br/> 经纬度半角逗号分隔 单位：°
        /// </summary>
        [XmlElement("geo")]
        public string Geo { get; set; }

        /// <summary>
        /// 6位行政区域编码 <br/> 至少到城市级编码，否则岗位无法展示，建议传到区(县)级编码，如: 浙江省杭州市西湖区=330106。 <br/> <a href="https://jiuye.yuque.com/org-wiki-jiuye-cpfcqs/araxo9/ed5yn3asbtes7ni4" target="_blank">全量城市行政区划编码（2020Q1版本）</a> <br/> <a href="https://jiuye.yuque.com/org-wiki-jiuye-cpfcqs/araxo9/yi0uix3f0babcfzi" target="_blank"> 全量区县行政区划编码（2020Q1版本） </a>
        /// </summary>
        [XmlElement("region_code")]
        public string RegionCode { get; set; }
    }
}
