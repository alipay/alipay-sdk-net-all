using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OrderShop Data Structure.
    /// </summary>
    [Serializable]
    public class OrderShop : AopObject
    {
        /// <summary>
        /// 法人身份证
        /// </summary>
        [XmlElement("legal_person_identity_card")]
        public string LegalPersonIdentityCard { get; set; }

        /// <summary>
        /// 店铺所在详细地址
        /// </summary>
        [XmlElement("shop_address")]
        public string ShopAddress { get; set; }

        /// <summary>
        /// 店铺所在市
        /// </summary>
        [XmlElement("shop_city")]
        public string ShopCity { get; set; }

        /// <summary>
        /// 店铺所在区/县
        /// </summary>
        [XmlElement("shop_district")]
        public string ShopDistrict { get; set; }

        /// <summary>
        /// 店铺行业,使用蚂蚁行业分类，可参考https://www.yuque.com/kangxia-ij2dr/kb/ybdoqb#ib45 注意：一级目录与行业使用"-"分隔
        /// </summary>
        [XmlElement("shop_industry")]
        public string ShopIndustry { get; set; }

        /// <summary>
        /// 店铺纬度
        /// </summary>
        [XmlElement("shop_latitude")]
        public string ShopLatitude { get; set; }

        /// <summary>
        /// 店铺营业执照照片
        /// </summary>
        [XmlElement("shop_licence_photo")]
        public string ShopLicencePhoto { get; set; }

        /// <summary>
        /// 店铺联系人电话
        /// </summary>
        [XmlElement("shop_linkman_mobile")]
        public string ShopLinkmanMobile { get; set; }

        /// <summary>
        /// 店铺联系人
        /// </summary>
        [XmlElement("shop_linkman_name")]
        public string ShopLinkmanName { get; set; }

        /// <summary>
        /// 店铺经度
        /// </summary>
        [XmlElement("shop_longitude")]
        public string ShopLongitude { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 店铺营业时间(时间范围 00:00-24:00 )
        /// </summary>
        [XmlElement("shop_open_time")]
        public string ShopOpenTime { get; set; }

        /// <summary>
        /// 店铺所在省
        /// </summary>
        [XmlElement("shop_province")]
        public string ShopProvince { get; set; }
    }
}
