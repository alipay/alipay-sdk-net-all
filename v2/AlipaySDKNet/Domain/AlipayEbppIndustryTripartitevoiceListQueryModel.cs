using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryTripartitevoiceListQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryTripartitevoiceListQueryModel : AopObject
    {
        /// <summary>
        /// 格式 yyyy-MM-dd，只能查 1 天的数据，不允许跨天
        /// </summary>
        [XmlElement("biz_date")]
        public string BizDate { get; set; }

        /// <summary>
        /// 页码，默认 1，从 1 开始
        /// </summary>
        [XmlElement("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 每页条数，默认 100，最大 1000
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 状态过滤；不传=查全部；多状态用半角逗号分隔（如 INIT,QUESTION_COMPLETED）
        /// </summary>
        [XmlElement("process_status")]
        public string ProcessStatus { get; set; }
    }
}
