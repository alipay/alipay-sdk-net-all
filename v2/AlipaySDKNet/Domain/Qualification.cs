using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Qualification Data Structure.
    /// </summary>
    [Serializable]
    public class Qualification : AopObject
    {
        /// <summary>
        /// 锚定物实例
        /// </summary>
        [XmlElement("anchor_instance")]
        public AnchorInstance AnchorInstance { get; set; }

        /// <summary>
        /// 资格申领状态
        /// </summary>
        [XmlElement("apply_status")]
        public string ApplyStatus { get; set; }

        /// <summary>
        /// 已经申领成功
        /// </summary>
        [XmlElement("apply_status_desc")]
        public string ApplyStatusDesc { get; set; }

        /// <summary>
        /// 领取的资格信息
        /// </summary>
        [XmlElement("asset_info")]
        public string AssetInfo { get; set; }

        /// <summary>
        /// 资格ID
        /// </summary>
        [XmlElement("qual_id")]
        public string QualId { get; set; }

        /// <summary>
        /// 资格实例
        /// </summary>
        [XmlElement("qualification_instance")]
        public QualInstanceDTO QualificationInstance { get; set; }

        /// <summary>
        /// 资格模板ID
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
