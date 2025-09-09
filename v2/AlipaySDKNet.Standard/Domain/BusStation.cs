using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BusStation Data Structure.
    /// </summary>
    [Serializable]
    public class BusStation : AopObject
    {
        /// <summary>
        /// 站点地址，参考高德地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 需要按照民政部标准： <a href='https://www.mca.gov.cn/mzsj/xzqh/2023/202301xzqh.html'>民政部城市区县编码</a> 例如:110000（北京市）
        /// </summary>
        [XmlElement("city_id")]
        public long CityId { get; set; }

        /// <summary>
        /// 城市中文名称
        /// </summary>
        [XmlElement("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 需要按照民政部标准： <a href='https://www.mca.gov.cn/mzsj/xzqh/2023/202301xzqh.html'>民政部城市区县编码</a> 例如杭州市部分区县： 区县id  名称        330102    上城区        330105    拱墅区        330106    西湖区        330108    滨江区        330109    萧山区
        /// </summary>
        [XmlElement("county_id")]
        public long CountyId { get; set; }

        /// <summary>
        /// 区县中文名称
        /// </summary>
        [XmlElement("county_name")]
        public string CountyName { get; set; }

        /// <summary>
        /// 高德地图poiID, 需要渠道保证准确性。缺失poiID会影响渠道资源的匹配率。 缺失poiID，平台默认使用经纬度距离200米以内+同名的规则进行匹配。
        /// </summary>
        [XmlElement("gaode_poiid")]
        public string GaodePoiid { get; set; }

        /// <summary>
        /// 站点纬度，统一用火星坐标系（参考高德） 需满足正则表达式： ^[+-]?([0-8]?\d(\.\d+)?|90(\.0+)?)$
        /// </summary>
        [XmlElement("lat")]
        public string Lat { get; set; }

        /// <summary>
        /// 站点经度，统一用火星坐标系（参考高德） 需满足正则表达式： ^[+-]?((180(\.0+)?|1[0-7]\d(\.\d+)?|[1-9]\d(\.\d+)?|\d(\.\d+)?))$
        /// </summary>
        [XmlElement("lng")]
        public string Lng { get; set; }

        /// <summary>
        /// 汽车站站点名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 渠道内部站点id，可用于汽车班次查询
        /// </summary>
        [XmlElement("station_id")]
        public string StationId { get; set; }

        /// <summary>
        /// 站点类型 0:汽车站 1:普通站点
        /// </summary>
        [XmlElement("station_type")]
        public long StationType { get; set; }
    }
}
