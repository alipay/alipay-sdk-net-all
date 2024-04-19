using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MerchantInformation Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantInformation : AopObject
    {
        /// <summary>
        /// 地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 预收金额
        /// </summary>
        [XmlElement("advance_amount")]
        public string AdvanceAmount { get; set; }

        /// <summary>
        /// 城市
        /// </summary>
        [XmlElement("city_desc")]
        public string CityDesc { get; set; }

        /// <summary>
        /// 计收模式和结算方式
        /// </summary>
        [XmlElement("collection_settlement")]
        public string CollectionSettlement { get; set; }

        /// <summary>
        /// 国家
        /// </summary>
        [XmlElement("country_desc")]
        public string CountryDesc { get; set; }

        /// <summary>
        /// 地区
        /// </summary>
        [XmlElement("district_desc")]
        public string DistrictDesc { get; set; }

        /// <summary>
        /// mcc码
        /// </summary>
        [XmlElement("mcc_code")]
        public string MccCode { get; set; }

        /// <summary>
        /// mcc一级类目
        /// </summary>
        [XmlElement("mcc_industry_one")]
        public string MccIndustryOne { get; set; }

        /// <summary>
        /// mcc二级类目
        /// </summary>
        [XmlElement("mcc_industry_two")]
        public string MccIndustryTwo { get; set; }

        /// <summary>
        /// 上面名称
        /// </summary>
        [XmlElement("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// mid
        /// </summary>
        [XmlElement("mid")]
        public string Mid { get; set; }

        /// <summary>
        /// 邮编
        /// </summary>
        [XmlElement("zip_code")]
        public string ZipCode { get; set; }
    }
}
