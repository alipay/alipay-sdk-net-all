using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AxfItemCategoryQualification Data Structure.
    /// </summary>
    [Serializable]
    public class AxfItemCategoryQualification : AopObject
    {
        /// <summary>
        /// 资质参数描述
        /// </summary>
        [XmlElement("param_description")]
        public string ParamDescription { get; set; }

        /// <summary>
        /// 资质内容。参考类目模版响应接口所需资质参数描述。如果需要图片先走图片上传接口获取图片id
        /// </summary>
        [XmlElement("qualification_content")]
        public string QualificationContent { get; set; }

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
