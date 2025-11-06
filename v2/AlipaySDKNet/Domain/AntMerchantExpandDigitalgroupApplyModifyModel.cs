using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandDigitalgroupApplyModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandDigitalgroupApplyModifyModel : AopObject
    {
        /// <summary>
        /// 高德门店地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 高德品牌ID
        /// </summary>
        [XmlElement("brand_id")]
        public string BrandId { get; set; }

        /// <summary>
        /// 高德品牌名称
        /// </summary>
        [XmlElement("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 营业执照号
        /// </summary>
        [XmlElement("business_license_no")]
        public string BusinessLicenseNo { get; set; }

        /// <summary>
        /// 门店营业执照图片
        /// </summary>
        [XmlElement("business_license_pic")]
        public string BusinessLicensePic { get; set; }

        /// <summary>
        /// 门店经营时间
        /// </summary>
        [XmlElement("business_time")]
        public string BusinessTime { get; set; }

        /// <summary>
        /// 高德门店末级类目
        /// </summary>
        [XmlElement("category_final")]
        public string CategoryFinal { get; set; }

        /// <summary>
        /// 一级类目
        /// </summary>
        [XmlElement("category_one")]
        public string CategoryOne { get; set; }

        /// <summary>
        /// 高德渠道
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 市
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 联系方式，多个联系方式逗号隔开
        /// </summary>
        [XmlElement("contact_phone")]
        public string ContactPhone { get; set; }

        /// <summary>
        /// 数字化门店ID
        /// </summary>
        [XmlElement("digital_poi_id")]
        public string DigitalPoiId { get; set; }

        /// <summary>
        /// 区
        /// </summary>
        [XmlElement("district")]
        public string District { get; set; }

        /// <summary>
        /// 高德门店扩展信息
        /// </summary>
        [XmlArray("ext_info")]
        [XmlArrayItem("shop_ext_info")]
        public List<ShopExtInfo> ExtInfo { get; set; }

        /// <summary>
        /// 高德门店名称
        /// </summary>
        [XmlElement("g_name")]
        public string GName { get; set; }

        /// <summary>
        /// 高德门店ID
        /// </summary>
        [XmlElement("g_shopid")]
        public string GShopid { get; set; }

        /// <summary>
        /// 门店纬度
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 法人身份证号
        /// </summary>
        [XmlElement("legal_person_card")]
        public string LegalPersonCard { get; set; }

        /// <summary>
        /// 法人姓名
        /// </summary>
        [XmlElement("legal_person_name")]
        public string LegalPersonName { get; set; }

        /// <summary>
        /// 门店经度
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 省
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }

        /// <summary>
        /// {}
        /// </summary>
        [XmlArray("shop_albums")]
        [XmlArrayItem("alipay_tag_v_o")]
        public List<AlipayTagVO> ShopAlbums { get; set; }

        /// <summary>
        /// OPEN("OPEN", "OPEN", "营业中", "营业中"), PAUSE("PAUSE", "PAUSE", "暂停营业", "暂停营业")
        /// </summary>
        [XmlElement("shop_business_status")]
        public string ShopBusinessStatus { get; set; }

        /// <summary>
        /// 门店视频
        /// </summary>
        [XmlArray("shop_videos")]
        [XmlArrayItem("string")]
        public List<string> ShopVideos { get; set; }

        /// <summary>
        /// VALID("VALID", "VALID","有效","有效"), INVALID("INVALID", "INVALID","无效","无效")
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 高德门脸照，至少一张，最多三张
        /// </summary>
        [XmlArray("store_head_pic")]
        [XmlArrayItem("string")]
        public List<string> StoreHeadPic { get; set; }

        /// <summary>
        /// 门店形象照
        /// </summary>
        [XmlElement("store_logo")]
        public string StoreLogo { get; set; }
    }
}
