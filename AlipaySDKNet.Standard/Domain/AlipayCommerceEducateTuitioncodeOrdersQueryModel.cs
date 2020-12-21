using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateTuitioncodeOrdersQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateTuitioncodeOrdersQueryModel : AopObject
    {
        /// <summary>
        /// 是否查询打款计划列表。true-查看；false-不查看
        /// </summary>
        [XmlElement("include_plans")]
        public bool IncludePlans { get; set; }

        /// <summary>
        /// 当前分页数
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 场景，固定"XFM"
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 二级商户在直付通的smid值
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }

        /// <summary>
        /// 若为空则查询全量，不支持多选。1打款调度中；2打款完成；3退款中；4退款完成。
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
