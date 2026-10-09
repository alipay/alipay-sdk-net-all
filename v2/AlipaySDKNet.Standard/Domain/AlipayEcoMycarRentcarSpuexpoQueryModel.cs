using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoMycarRentcarSpuexpoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarRentcarSpuexpoQueryModel : AopObject
    {
        /// <summary>
        /// 查询某日的曝光数据，最多支持近七天
        /// </summary>
        [XmlElement("bizdate")]
        public string Bizdate { get; set; }

        /// <summary>
        /// 车型类型
        /// </summary>
        [XmlElement("car_type")]
        public string CarType { get; set; }

        /// <summary>
        /// 城市名
        /// </summary>
        [XmlElement("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 每页条数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 品牌名称
        /// </summary>
        [XmlElement("veh_name")]
        public string VehName { get; set; }
    }
}
