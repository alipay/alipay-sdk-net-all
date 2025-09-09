using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CustomGoodsVO Data Structure.
    /// </summary>
    [Serializable]
    public class CustomGoodsVO : AopObject
    {
        /// <summary>
        /// 商品的售卖价格，单位：元，精确到小数点后两位数字。
        /// </summary>
        [XmlElement("activity_price")]
        public string ActivityPrice { get; set; }

        /// <summary>
        /// 支持.jpg,.png格式，图片宽高比1:1，2M以内。请先通过图片上传接口上传图片，并获取到 file_id 作为这个入参的值。 【注意事项】支持.jpg,.png格式，图片宽高比1:1，2M以内
        /// </summary>
        [XmlElement("image_id")]
        public string ImageId { get; set; }

        /// <summary>
        /// 商品的原始价格，单位：元，精确到小数点后两位数
        /// </summary>
        [XmlElement("original_price")]
        public string OriginalPrice { get; set; }

        /// <summary>
        /// 返回该商品的标签
        /// </summary>
        [XmlArray("tags")]
        [XmlArrayItem("string")]
        public List<string> Tags { get; set; }

        /// <summary>
        /// 商品的名称
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 商品详情的跳转链接
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
