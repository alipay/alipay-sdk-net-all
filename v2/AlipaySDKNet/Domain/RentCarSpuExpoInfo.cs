using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentCarSpuExpoInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RentCarSpuExpoInfo : AopObject
    {
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
        /// 曝光排名(曝光量越大值越小)
        /// </summary>
        [XmlElement("expo_rank")]
        public long ExpoRank { get; set; }

        /// <summary>
        /// 分城市订单排名（订单量越大值越小）
        /// </summary>
        [XmlElement("order_rank")]
        public long OrderRank { get; set; }

        /// <summary>
        /// spu的标识
        /// </summary>
        [XmlElement("spu_id")]
        public string SpuId { get; set; }

        /// <summary>
        /// spu名称
        /// </summary>
        [XmlElement("spu_name")]
        public string SpuName { get; set; }

        /// <summary>
        /// 车型品牌
        /// </summary>
        [XmlElement("veh_name")]
        public string VehName { get; set; }
    }
}
