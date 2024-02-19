using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MedicalGuideTab Data Structure.
    /// </summary>
    [Serializable]
    public class MedicalGuideTab : AopObject
    {
        /// <summary>
        /// 按钮名称
        /// </summary>
        [XmlElement("btn_name")]
        public string BtnName { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 科室类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
