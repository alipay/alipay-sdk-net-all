using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLifeserviceUnifiedshopBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLifeserviceUnifiedshopBatchqueryModel : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("city_codes")]
        [XmlArrayItem("string")]
        public List<string> CityCodes { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("district_codes")]
        [XmlArrayItem("string")]
        public List<string> DistrictCodes { get; set; }

        /// <summary>
        /// 是否有营业执照
        /// </summary>
        [XmlElement("has_business_license")]
        public bool HasBusinessLicense { get; set; }

        /// <summary>
        /// 页码（必填，大于0）
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页条数（必填，范围1~100）
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("province_codes")]
        [XmlArrayItem("string")]
        public List<string> ProvinceCodes { get; set; }

        /// <summary>
        /// 蚂蚁门店ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 门店名称（模糊搜索）
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 门店类型: PHYSICAL_STORE-线下门店 / CLOUD_STORE-线上云店
        /// </summary>
        [XmlElement("shop_type")]
        public string ShopType { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("status")]
        [XmlArrayItem("string")]
        public List<string> Status { get; set; }

        /// <summary>
        /// 统一门店ID
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }
    }
}
