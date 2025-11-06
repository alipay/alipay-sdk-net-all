using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SignAddressInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SignAddressInfo : AopObject
    {
        /// <summary>
        /// 城市编码。请按照<a href="https://mdn.alipayobjects.com/huamei_sm7gq8/afts/file/A*blT9RqSR9_gAAAAAAAAAAAAADuKQAQ/2022%E8%9A%82%E8%9A%81%E9%87%91%E6%9C%8D%E5%9C%B0%E5%8C%BA%E7%A0%81.xlsx">地区码表格</a> 中内容填写。 （参考资料： <a href="https://www.mca.gov.cn/n156/n186/index.html">参考资料</a>）
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 国家编码，中国默认：156
        /// </summary>
        [XmlElement("country_code")]
        public string CountryCode { get; set; }

        /// <summary>
        /// 详细地址
        /// </summary>
        [XmlElement("detail_address")]
        public string DetailAddress { get; set; }

        /// <summary>
        /// 区县编码。请按照<a href="https://mdn.alipayobjects.com/huamei_sm7gq8/afts/file/A*blT9RqSR9_gAAAAAAAAAAAAADuKQAQ/2022%E8%9A%82%E8%9A%81%E9%87%91%E6%9C%8D%E5%9C%B0%E5%8C%BA%E7%A0%81.xlsx">地区码表格</a> 中内容填写。 （参考资料： <a href="https://www.mca.gov.cn/n156/n186/index.html">参考资料</a>）
        /// </summary>
        [XmlElement("district_code")]
        public string DistrictCode { get; set; }

        /// <summary>
        /// 纬度，浮点型,小数点后最多保留6位 如需要录入经纬度，请以高德坐标系为准，录入时请确保经纬度参数准确。高德经纬度查询：<a href="http://lbs.amap.com/console/show/picker">查询地址</a>
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 经度，浮点型, 小数点后最多保留6位。 如需要录入经纬度，请以高德坐标系为准，录入时请确保经纬度参数准确。高德经纬度查询：<a href="http://lbs.amap.com/console/show/picker">查询地址</a>
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 省份编码。请按照<a href="https://mdn.alipayobjects.com/huamei_sm7gq8/afts/file/A*blT9RqSR9_gAAAAAAAAAAAAADuKQAQ/2022%E8%9A%82%E8%9A%81%E9%87%91%E6%9C%8D%E5%9C%B0%E5%8C%BA%E7%A0%81.xlsx">地区码表格</a> 中内容填写。 （参考资料： <a href="https://www.mca.gov.cn/n156/n186/index.html">参考资料</a>）
        /// </summary>
        [XmlElement("province_code")]
        public string ProvinceCode { get; set; }
    }
}
