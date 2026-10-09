using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ShopItemInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ShopItemInfo : AopObject
    {
        /// <summary>
        /// 店铺地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 店铺类别
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
        /// 详情页面
        /// </summary>
        [XmlElement("detail_url")]
        public string DetailUrl { get; set; }

        /// <summary>
        /// 店铺楼层
        /// </summary>
        [XmlElement("floor")]
        public string Floor { get; set; }

        /// <summary>
        /// 店铺id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 商品归属的小程序ID
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 营业时间
        /// </summary>
        [XmlElement("open_time")]
        public string OpenTime { get; set; }

        /// <summary>
        /// 时间戳
        /// </summary>
        [XmlElement("operate_time")]
        public string OperateTime { get; set; }

        /// <summary>
        /// 店铺评分（保留两位小数）
        /// </summary>
        [XmlElement("shop_grade")]
        public string ShopGrade { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 店铺电话
        /// </summary>
        [XmlElement("shop_phone_no")]
        public string ShopPhoneNo { get; set; }

        /// <summary>
        /// 店铺图片链接
        /// </summary>
        [XmlArray("shop_url")]
        [XmlArrayItem("string")]
        public List<string> ShopUrl { get; set; }

        /// <summary>
        /// 店铺状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 优惠标签
        /// </summary>
        [XmlArray("tags")]
        [XmlArrayItem("string")]
        public List<string> Tags { get; set; }

        /// <summary>
        /// 标题，用于搜索
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 总销量
        /// </summary>
        [XmlElement("total_sale_number")]
        public string TotalSaleNumber { get; set; }
    }
}
