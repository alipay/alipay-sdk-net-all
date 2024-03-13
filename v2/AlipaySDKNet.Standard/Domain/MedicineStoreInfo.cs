using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MedicineStoreInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MedicineStoreInfo : AopObject
    {
        /// <summary>
        /// 门店详细地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [XmlElement("app_store_id")]
        public string AppStoreId { get; set; }

        /// <summary>
        /// 门店所在地级行政区划编码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 门店所在地级行政区划名称
        /// </summary>
        [XmlElement("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 用户和门店的距离(单位：米)
        /// </summary>
        [XmlElement("distance")]
        public long Distance { get; set; }

        /// <summary>
        /// 免配送费门槛价
        /// </summary>
        [XmlElement("free_shipping_price")]
        public long FreeShippingPrice { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 门店Logo
        /// </summary>
        [XmlElement("logo_image")]
        public string LogoImage { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 定点医药机构编码 医保相关业务必填
        /// </summary>
        [XmlElement("medical_org_no")]
        public string MedicalOrgNo { get; set; }

        /// <summary>
        /// 门店所在省行政区划编码
        /// </summary>
        [XmlElement("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 门店所在省行政区划名称
        /// </summary>
        [XmlElement("province_name")]
        public string ProvinceName { get; set; }

        /// <summary>
        /// 该区域配送费
        /// </summary>
        [XmlElement("shipping_fee")]
        public long ShippingFee { get; set; }

        /// <summary>
        /// 起送价
        /// </summary>
        [XmlElement("shipping_price")]
        public long ShippingPrice { get; set; }

        /// <summary>
        /// 门店名称
        /// </summary>
        [XmlElement("store_name")]
        public string StoreName { get; set; }

        /// <summary>
        /// 标签列表
        /// </summary>
        [XmlArray("tag_list")]
        [XmlArrayItem("medicine_tag_info")]
        public List<MedicineTagInfo> TagList { get; set; }
    }
}
