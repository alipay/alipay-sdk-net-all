using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenQueryPoimBaseResponse Data Structure.
    /// </summary>
    [Serializable]
    public class OpenQueryPoimBaseResponse : AopObject
    {
        /// <summary>
        /// 地址。商户详细经营地址或人员所在地点
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// address_id 查询业务主键,一个address_id 对应一个商家地址,地址下面有名称,地址,经纬度,省市区,等基础信息
        /// </summary>
        [XmlElement("address_id")]
        public string AddressId { get; set; }

        /// <summary>
        /// 城市编码。 蚂蚁店铺请按照<a href="https://mdn.alipayobjects.com/huamei_sm7gq8/afts/file/A*blT9RqSR9_gAAAAAAAAAAAAADuKQAQ/2022%E8%9A%82%E8%9A%81%E9%87%91%E6%9C%8D%E5%9C%B0%E5%8C%BA%E7%A0%81.xlsx" target="_blank">蚂蚁店铺地区码</a> 表格中填写。 直付通商户请按照<a href="https://gw.alipayobjects.com/os/basement_prod/253c4dcb-b8a4-4a1e-8be2-79e191a9b6db.xlsx " target="_blank">直付通商户地区码</a> 表格中内容填写。
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 城市名称
        /// </summary>
        [XmlElement("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 区县编码。 蚂蚁店铺请按照<a href="https://mdn.alipayobjects.com/huamei_sm7gq8/afts/file/A*blT9RqSR9_gAAAAAAAAAAAAADuKQAQ/2022%E8%9A%82%E8%9A%81%E9%87%91%E6%9C%8D%E5%9C%B0%E5%8C%BA%E7%A0%81.xlsx" target="_blank">蚂蚁店铺地区码</a> 表格中填写。 直付通商户请按照<a href="https://gw.alipayobjects.com/os/basement_prod/253c4dcb-b8a4-4a1e-8be2-79e191a9b6db.xlsx " target="_blank">直付通商户地区码</a> 表格中内容填写。
        /// </summary>
        [XmlElement("district_code")]
        public string DistrictCode { get; set; }

        /// <summary>
        /// 区县名称
        /// </summary>
        [XmlElement("district_name")]
        public string DistrictName { get; set; }

        /// <summary>
        /// 纬度，浮点型,小数点后最多保留6位 如需要录入经纬度，请以高德坐标系为准，录入时请确保经纬度参数准确。高德经纬度查询
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 经度，浮点型, 小数点后最多保留6位。 如需要录入经纬度，请以高德坐标系为准，录入时请确保经纬度参数准确。高德经纬度查询
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 商家地址库下管理对应的商家名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 省份编码。 蚂蚁店铺请按照<a href="https://mdn.alipayobjects.com/huamei_sm7gq8/afts/file/A*blT9RqSR9_gAAAAAAAAAAAAADuKQAQ/2022%E8%9A%82%E8%9A%81%E9%87%91%E6%9C%8D%E5%9C%B0%E5%8C%BA%E7%A0%81.xlsx" target="_blank">蚂蚁店铺地区码</a> 表格中填写。 直付通商户请按照<a href="https://gw.alipayobjects.com/os/basement_prod/253c4dcb-b8a4-4a1e-8be2-79e191a9b6db.xlsx " target="_blank">直付通商户地区码</a> 表格中内容填写。
        /// </summary>
        [XmlElement("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 省份名称
        /// </summary>
        [XmlElement("province_name")]
        public string ProvinceName { get; set; }
    }
}
