using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecycleAuctionBuyerInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class RecycleAuctionBuyerInfoVO : AopObject
    {
        /// <summary>
        /// 买家详细地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 买家标识
        /// </summary>
        [XmlElement("buyer_identify")]
        public string BuyerIdentify { get; set; }

        /// <summary>
        /// 买家手机号
        /// </summary>
        [XmlElement("buyer_mobile")]
        public string BuyerMobile { get; set; }

        /// <summary>
        /// 买家名称
        /// </summary>
        [XmlElement("buyer_name")]
        public string BuyerName { get; set; }

        /// <summary>
        /// 市区
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 买家市编码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 区县
        /// </summary>
        [XmlElement("distinct")]
        public string Distinct { get; set; }

        /// <summary>
        /// 买家区县编码
        /// </summary>
        [XmlElement("district_code")]
        public string DistrictCode { get; set; }

        /// <summary>
        /// 省份
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }

        /// <summary>
        /// 买家省份编码
        /// </summary>
        [XmlElement("province_code")]
        public string ProvinceCode { get; set; }
    }
}
