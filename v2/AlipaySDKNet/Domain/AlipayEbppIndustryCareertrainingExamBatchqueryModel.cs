using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryCareertrainingExamBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryCareertrainingExamBatchqueryModel : AopObject
    {
        /// <summary>
        /// ● 湖南省全省:  430000   ● 浙江省-杭州市:  330100   ● 浙江省-杭州市-余杭区:  330110 
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// （用于支付宝一方页面的分类筛选）
        /// </summary>
        [XmlElement("exam_name")]
        public string ExamName { get; set; }

        /// <summary>
        /// 定义外部评价ID, 与本系统评价关联
        /// </summary>
        [XmlElement("out_exam_id")]
        public string OutExamId { get; set; }

        /// <summary>
        /// 页码 
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页条数: 最大50
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
