using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SearchOrderDetailDataBrandItems Data Structure.
    /// </summary>
    [Serializable]
    public class SearchOrderDetailDataBrandItems : AopObject
    {
        /// <summary>
        /// 工单详情bizid
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 上下架状态
        /// </summary>
        [XmlElement("box_status")]
        public string BoxStatus { get; set; }

        /// <summary>
        /// 关键词信息
        /// </summary>
        [XmlElement("brand_box_keywords")]
        public string BrandBoxKeywords { get; set; }

        /// <summary>
        /// 品牌展示模板类型
        /// </summary>
        [XmlElement("brand_template_id")]
        public string BrandTemplateId { get; set; }

        /// <summary>
        /// 工单详情数据channel
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 工单详情数据信息
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("search_order_brand_detail")]
        public List<SearchOrderBrandDetail> Data { get; set; }

        /// <summary>
        /// 工单详情数据merchant_type
        /// </summary>
        [XmlElement("merchant_type")]
        public string MerchantType { get; set; }

        /// <summary>
        /// 模板id
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
