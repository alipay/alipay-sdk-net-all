using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalExaminationBundlelistQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalExaminationBundlelistQueryModel : AopObject
    {
        /// <summary>
        /// 标签编码(对应是检查类型或者检验类型) CHECK_CATEGORY、 检验类目类型： INSPECTION_CATEGORY  不传默认查全部的
        /// </summary>
        [XmlElement("tag_code")]
        public string TagCode { get; set; }
    }
}
