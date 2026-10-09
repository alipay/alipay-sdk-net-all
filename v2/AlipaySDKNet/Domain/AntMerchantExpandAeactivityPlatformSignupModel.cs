using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandAeactivityPlatformSignupModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandAeactivityPlatformSignupModel : AopObject
    {
        /// <summary>
        /// 点餐码url
        /// </summary>
        [XmlElement("catering_url")]
        public string CateringUrl { get; set; }

        /// <summary>
        /// 饿了么门店地址
        /// </summary>
        [XmlElement("ele_address")]
        public string EleAddress { get; set; }

        /// <summary>
        /// 饿了么门店品牌id
        /// </summary>
        [XmlElement("ele_brand_id")]
        public string EleBrandId { get; set; }

        /// <summary>
        /// 饿了么门店品牌名称
        /// </summary>
        [XmlElement("ele_brand_name")]
        public string EleBrandName { get; set; }

        /// <summary>
        /// 饿了么门店一级类目
        /// </summary>
        [XmlElement("ele_category_1")]
        public string EleCategory1 { get; set; }

        /// <summary>
        /// 饿了么门店二级类目
        /// </summary>
        [XmlElement("ele_category_2")]
        public string EleCategory2 { get; set; }

        /// <summary>
        /// 饿了么门店纬度
        /// </summary>
        [XmlElement("ele_latitude")]
        public string EleLatitude { get; set; }

        /// <summary>
        /// 门店经度
        /// </summary>
        [XmlElement("ele_longitude")]
        public string EleLongitude { get; set; }

        /// <summary>
        /// 饿了么门店门头照url，需要是永久可用的图片公网链接
        /// </summary>
        [XmlElement("ele_outdoor_pic_url")]
        public string EleOutdoorPicUrl { get; set; }

        /// <summary>
        /// 饿了么门店联系电话/手机号
        /// </summary>
        [XmlElement("ele_phone")]
        public string ElePhone { get; set; }

        /// <summary>
        /// 饿了么门店名称
        /// </summary>
        [XmlElement("ele_shop_name")]
        public string EleShopName { get; set; }

        /// <summary>
        /// 饿了么门店shopid
        /// </summary>
        [XmlElement("ele_shopid")]
        public string EleShopid { get; set; }

        /// <summary>
        /// 饿了么门店扩展信息
        /// </summary>
        [XmlArray("ext_info")]
        [XmlArrayItem("shop_ext_info")]
        public List<ShopExtInfo> ExtInfo { get; set; }

        /// <summary>
        /// 设备sn码
        /// </summary>
        [XmlElement("sn_code")]
        public string SnCode { get; set; }
    }
}
