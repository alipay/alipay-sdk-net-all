using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AppItemDataDiffVO Data Structure.
    /// </summary>
    [Serializable]
    public class AppItemDataDiffVO : AopObject
    {
        /// <summary>
        /// 【描述】商品主图的文件id/url，图片宽高为750px*750px，宽高比1:1，800kb以内。 支持jpg、jpeg、png格式的图片。
        /// </summary>
        [XmlElement("head_img")]
        public string HeadImg { get; set; }

        /// <summary>
        /// 商品子图，作为平台详情页组件的轮播图，图片宽高为750px*750px，宽高比1:1，800kb以内，不超过 3 个图片。 支持jpg、jpeg、png格式的图片。
        /// </summary>
        [XmlArray("image_list")]
        [XmlArrayItem("string")]
        public List<string> ImageList { get; set; }

        /// <summary>
        /// 商品售卖状态
        /// </summary>
        [XmlElement("sale_status")]
        public string SaleStatus { get; set; }

        /// <summary>
        /// 商品sku变更内容列表
        /// </summary>
        [XmlArray("skus")]
        [XmlArrayItem("app_item_sku_diff_v_o")]
        public List<AppItemSkuDiffVO> Skus { get; set; }

        /// <summary>
        /// 商品名称，字符类型，最少不低于3，最长不超过60个字。注：1.商品标题只允许汉字、数字、英文字母、特殊字符集；2.商品标题不得仅为数字、字母、特殊字符集或上述三种的组合
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
