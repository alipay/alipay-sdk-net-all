using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AxfItemCategoryQualificationReq Data Structure.
    /// </summary>
    [Serializable]
    public class AxfItemCategoryQualificationReq : AopObject
    {
        /// <summary>
        /// 资质内容。参考类目模版响应接口所需资质参数描述。如果需要图片先走图片上传接口获取图片id
        /// </summary>
        [XmlElement("qualification_content")]
        public string QualificationContent { get; set; }

        /// <summary>
        /// 资质类型
        /// </summary>
        [XmlElement("qualification_type")]
        public string QualificationType { get; set; }
    }
}
