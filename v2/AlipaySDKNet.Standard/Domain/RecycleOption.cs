using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecycleOption Data Structure.
    /// </summary>
    [Serializable]
    public class RecycleOption : AopObject
    {
        /// <summary>
        /// 选项code
        /// </summary>
        [XmlElement("option_code")]
        public string OptionCode { get; set; }

        /// <summary>
        /// 选项名称
        /// </summary>
        [XmlElement("option_name")]
        public string OptionName { get; set; }

        /// <summary>
        /// 问卷选项关系id
        /// </summary>
        [XmlElement("relation_id")]
        public string RelationId { get; set; }
    }
}
