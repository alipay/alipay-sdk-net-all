using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MedicalGuideContentDTO Data Structure.
    /// </summary>
    [Serializable]
    public class MedicalGuideContentDTO : AopObject
    {
        /// <summary>
        /// 卡片格式数据渲染
        /// </summary>
        [XmlElement("card")]
        public MedicalGuideCardDTO Card { get; set; }

        /// <summary>
        /// 描述文本
        /// </summary>
        [XmlElement("text")]
        public string Text { get; set; }
    }
}
