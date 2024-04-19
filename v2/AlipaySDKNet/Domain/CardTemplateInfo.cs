using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CardTemplateInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CardTemplateInfo : AopObject
    {
        /// <summary>
        /// 卡模版ID
        /// </summary>
        [XmlElement("card_template_id")]
        public string CardTemplateId { get; set; }

        /// <summary>
        /// 卡模版名称
        /// </summary>
        [XmlElement("card_template_name")]
        public string CardTemplateName { get; set; }

        /// <summary>
        /// 卡模版状态
        /// </summary>
        [XmlElement("card_template_status")]
        public string CardTemplateStatus { get; set; }

        /// <summary>
        /// 类目ID
        /// </summary>
        [XmlElement("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 卡封面图ID
        /// </summary>
        [XmlArray("image_id_list")]
        [XmlArrayItem("string")]
        public List<string> ImageIdList { get; set; }

        /// <summary>
        /// 卡封面图Url
        /// </summary>
        [XmlArray("image_url_list")]
        [XmlArrayItem("string")]
        public List<string> ImageUrlList { get; set; }

        /// <summary>
        /// 行业方案类型
        /// </summary>
        [XmlElement("industry_solution_type")]
        public string IndustrySolutionType { get; set; }

        /// <summary>
        /// 外部卡ID
        /// </summary>
        [XmlElement("out_card_id")]
        public string OutCardId { get; set; }

        /// <summary>
        /// 卡模版归属人
        /// </summary>
        [XmlElement("owner")]
        public string Owner { get; set; }

        /// <summary>
        /// 售卖信息
        /// </summary>
        [XmlElement("sale_info")]
        public CardTemplateSaleInfo SaleInfo { get; set; }

        /// <summary>
        /// 使用信息
        /// </summary>
        [XmlElement("use_info")]
        public CardTemplateUseInfo UseInfo { get; set; }
    }
}
