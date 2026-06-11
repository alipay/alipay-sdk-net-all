using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ReportCommentDetailDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ReportCommentDetailDTO : AopObject
    {
        /// <summary>
        /// 详细描述
        /// </summary>
        [XmlElement("details")]
        public string Details { get; set; }

        /// <summary>
        /// 字段名称
        /// </summary>
        [XmlElement("field_name")]
        public string FieldName { get; set; }

        /// <summary>
        /// 十分制
        /// </summary>
        [XmlElement("score")]
        public long Score { get; set; }

        /// <summary>
        /// 百分比
        /// </summary>
        [XmlElement("weight")]
        public long Weight { get; set; }
    }
}
