using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ShopQueryOpenApiVO Data Structure.
    /// </summary>
    [Serializable]
    public class ShopQueryOpenApiVO : AopObject
    {
        /// <summary>
        /// 经营地址
        /// </summary>
        [XmlElement("business_address")]
        public AddressInfo BusinessAddress { get; set; }

        /// <summary>
        /// 店铺经营时间
        /// </summary>
        [XmlArray("business_time")]
        [XmlArrayItem("shop_business_time")]
        public List<ShopBusinessTime> BusinessTime { get; set; }

        /// <summary>
        /// 店铺联系手机
        /// </summary>
        [XmlElement("contact_mobile")]
        public string ContactMobile { get; set; }

        /// <summary>
        /// 店铺的联系固话
        /// </summary>
        [XmlElement("contact_phone")]
        public string ContactPhone { get; set; }

        /// <summary>
        /// 新版门店类目标准二级类目code.类目标准及与原shop_category映射关系参见<a href="https://gw.alipayobjects.com/os/bmw-prod/4b3f82df-e53e-4b84-bc41-fe025101e726.xlsx">文档</a>
        /// </summary>
        [XmlElement("new_shop_category")]
        public string NewShopCategory { get; set; }

        /// <summary>
        /// 店铺类目.取值参见文件<a href="https://mif-pub.alipayobjects.com/ShopCategory.xlsx">文件</a>中的三级门店类目
        /// </summary>
        [XmlElement("shop_category")]
        public string ShopCategory { get; set; }

        /// <summary>
        /// 蚂蚁店铺id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 当前名称、地址、经纬度信息准确一致，可用于数字化经营场景消费
        /// </summary>
        [XmlElement("shop_info_status")]
        public string ShopInfoStatus { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 门店状态
        /// </summary>
        [XmlElement("shop_status")]
        public string ShopStatus { get; set; }

        /// <summary>
        /// 店铺经营类型
        /// </summary>
        [XmlElement("shop_type")]
        public string ShopType { get; set; }

        /// <summary>
        /// 门店编号，表示该门店在该商户角色id(直连pid，间连smid)下，由商户自己定义的外部门店编号
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }
    }
}
