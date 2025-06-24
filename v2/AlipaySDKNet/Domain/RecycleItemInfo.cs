using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecycleItemInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RecycleItemInfo : AopObject
    {
        /// <summary>
        /// 预估价格，单位元
        /// </summary>
        [XmlElement("assess_amount")]
        public string AssessAmount { get; set; }

        /// <summary>
        /// 预估最高金额，单位元
        /// </summary>
        [XmlElement("assess_amount_max")]
        public string AssessAmountMax { get; set; }

        /// <summary>
        /// 预估最低金额，单位元
        /// </summary>
        [XmlElement("assess_amount_min")]
        public string AssessAmountMin { get; set; }

        /// <summary>
        /// 品牌code
        /// </summary>
        [XmlElement("brand_code")]
        public string BrandCode { get; set; }

        /// <summary>
        /// 品类code
        /// </summary>
        [XmlElement("category_code")]
        public string CategoryCode { get; set; }

        /// <summary>
        /// 可预付金额，单位元
        /// </summary>
        [XmlElement("pre_assess_amount")]
        public string PreAssessAmount { get; set; }

        /// <summary>
        /// 产品编码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 单个回收商品ID
        /// </summary>
        [XmlElement("product_item_id")]
        public string ProductItemId { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        [XmlElement("product_name")]
        public string ProductName { get; set; }

        /// <summary>
        /// 回收问题
        /// </summary>
        [XmlArray("question_list")]
        [XmlArrayItem("recycle_question")]
        public List<RecycleQuestion> QuestionList { get; set; }
    }
}
