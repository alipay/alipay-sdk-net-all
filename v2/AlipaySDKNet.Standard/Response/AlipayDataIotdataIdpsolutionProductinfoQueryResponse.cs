using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataIotdataIdpsolutionProductinfoQueryResponse.
    /// </summary>
    public class AlipayDataIotdataIdpsolutionProductinfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 商品品牌名称
        /// </summary>
        [XmlElement("brand")]
        public string Brand { get; set; }

        /// <summary>
        /// 商品一级分类
        /// </summary>
        [XmlElement("category_name_1")]
        public string CategoryName1 { get; set; }

        /// <summary>
        /// 商品二级分类
        /// </summary>
        [XmlElement("category_name_2")]
        public string CategoryName2 { get; set; }

        /// <summary>
        /// 商品三级分类
        /// </summary>
        [XmlElement("category_name_3")]
        public string CategoryName3 { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 商品图片链接
        /// </summary>
        [XmlElement("image")]
        public string Image { get; set; }

        /// <summary>
        /// 商品长宽高描述
        /// </summary>
        [XmlElement("size")]
        public ProductSize Size { get; set; }

        /// <summary>
        /// 商品规格描述
        /// </summary>
        [XmlElement("specification")]
        public string Specification { get; set; }
    }
}
