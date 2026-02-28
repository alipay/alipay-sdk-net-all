using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AxfItemCategoryQualificationVO Data Structure.
    /// </summary>
    [Serializable]
    public class AxfItemCategoryQualificationVO : AopObject
    {
        /// <summary>
        /// 资质参数描述
        /// </summary>
        [XmlElement("param_description")]
        public string ParamDescription { get; set; }

        /// <summary>
        /// 资质名称
        /// </summary>
        [XmlElement("qualification_name")]
        public string QualificationName { get; set; }

        /// <summary>
        /// 资质类型
        /// </summary>
        [XmlElement("qualification_type")]
        public string QualificationType { get; set; }
    }
}
