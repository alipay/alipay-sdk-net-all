using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MpcpromoShopList Data Structure.
    /// </summary>
    [Serializable]
    public class MpcpromoShopList : AopObject
    {
        /// <summary>
        /// 详细地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 店铺分类
        /// </summary>
        [XmlArray("category")]
        [XmlArrayItem("string")]
        public List<string> Category { get; set; }

        /// <summary>
        /// 内容描述，用于搜索
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 店铺url地址
        /// </summary>
        [XmlElement("detail_url")]
        public string DetailUrl { get; set; }

        /// <summary>
        /// 楼层说明
        /// </summary>
        [XmlElement("floor")]
        public string Floor { get; set; }

        /// <summary>
        /// 营业时间
        /// </summary>
        [XmlElement("open_time")]
        public string OpenTime { get; set; }

        /// <summary>
        /// 店铺评分0-100
        /// </summary>
        [XmlElement("shop_grade")]
        public long ShopGrade { get; set; }

        /// <summary>
        /// shopId唯一
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// shopName店铺名称，必填
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 店铺手机或者电话
        /// </summary>
        [XmlElement("shop_phone_no")]
        public string ShopPhoneNo { get; set; }

        /// <summary>
        /// 店铺图片url，数组的形式
        /// </summary>
        [XmlArray("shop_url")]
        [XmlArrayItem("string")]
        public List<string> ShopUrl { get; set; }

        /// <summary>
        /// status用0或1，1就是上架，0下架
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 标签，如五折，包邮
        /// </summary>
        [XmlArray("tags")]
        [XmlArrayItem("string")]
        public List<string> Tags { get; set; }

        /// <summary>
        /// 店铺标题，用于搜索
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 销量
        /// </summary>
        [XmlElement("total_sale_number")]
        public long TotalSaleNumber { get; set; }
    }
}
