using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFincoreComplianceApccenterAlgorithmarchiveDetectResponse.
    /// </summary>
    public class AlipayFincoreComplianceApccenterAlgorithmarchiveDetectResponse : AopResponse
    {
        /// <summary>
        /// 是否允许跳过
        /// </summary>
        [XmlElement("can_skip")]
        public bool CanSkip { get; set; }

        /// <summary>
        /// 是否禁用操作
        /// </summary>
        [XmlElement("disable_operation")]
        public bool DisableOperation { get; set; }

        /// <summary>
        /// 编辑算法档案url地址
        /// </summary>
        [XmlElement("edit_url")]
        public string EditUrl { get; set; }

        /// <summary>
        /// 是否需要完善
        /// </summary>
        [XmlElement("has_perfect")]
        public bool HasPerfect { get; set; }

        /// <summary>
        /// 平台算法唯一编码
        /// </summary>
        [XmlElement("platform_algorithm_code")]
        public string PlatformAlgorithmCode { get; set; }

        /// <summary>
        /// 平台算法来源
        /// </summary>
        [XmlElement("platform_algorithm_source")]
        public string PlatformAlgorithmSource { get; set; }

        /// <summary>
        /// 提醒文本div的html
        /// </summary>
        [XmlElement("remind_text")]
        public string RemindText { get; set; }

        /// <summary>
        /// 查看算法档案url地址
        /// </summary>
        [XmlElement("view_url")]
        public string ViewUrl { get; set; }
    }
}
