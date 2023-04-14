using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IndirectSupportCredentials Data Structure.
    /// </summary>
    [Serializable]
    public class IndirectSupportCredentials : AopObject
    {
        /// <summary>
        /// 门店城市
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 门店市行政区号（数字）
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 门店街道
        /// </summary>
        [XmlElement("district")]
        public string District { get; set; }

        /// <summary>
        /// 门店街道区号（数字）
        /// </summary>
        [XmlElement("district_code")]
        public string DistrictCode { get; set; }

        /// <summary>
        /// 小微商户经营类型，枚举值：门店场所（STORE）、流动经营（STALL）
        /// </summary>
        [XmlElement("merchant_type")]
        public string MerchantType { get; set; }

        /// <summary>
        /// 门店省份
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }

        /// <summary>
        /// 门店省行政区号（数字
        /// </summary>
        [XmlElement("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 门店场所填写门店详细地址，流动经营类型填“无”
        /// </summary>
        [XmlElement("store_address")]
        public string StoreAddress { get; set; }

        /// <summary>
        /// 门店门头照信息或摊位照（使用图片上传接口）
        /// </summary>
        [XmlElement("store_door_img")]
        public string StoreDoorImg { get; set; }

        /// <summary>
        /// 门店店内照片或者摊位照侧面（使用图片上传接口）
        /// </summary>
        [XmlElement("store_inner_img")]
        public string StoreInnerImg { get; set; }

        /// <summary>
        /// 门店名称
        /// </summary>
        [XmlElement("store_name")]
        public string StoreName { get; set; }
    }
}
