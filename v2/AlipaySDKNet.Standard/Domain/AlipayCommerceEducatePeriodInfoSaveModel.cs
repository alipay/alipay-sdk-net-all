using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducatePeriodInfoSaveModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducatePeriodInfoSaveModel : AopObject
    {
        /// <summary>
        /// 机构内标
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 操作人姓名
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 课时配置列表
        /// </summary>
        [XmlArray("period_config_list")]
        [XmlArrayItem("edu_period_config")]
        public List<EduPeriodConfig> PeriodConfigList { get; set; }

        /// <summary>
        /// 课时描述
        /// </summary>
        [XmlElement("period_desc")]
        public string PeriodDesc { get; set; }

        /// <summary>
        /// 课时ID
        /// </summary>
        [XmlElement("period_id")]
        public string PeriodId { get; set; }

        /// <summary>
        /// 课时名称
        /// </summary>
        [XmlElement("period_name")]
        public string PeriodName { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
