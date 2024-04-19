using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFincoreComplianceTemplateInstanceDownloadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFincoreComplianceTemplateInstanceDownloadModel : AopObject
    {
        /// <summary>
        /// 链接持续时间（分钟）
        /// </summary>
        [XmlElement("duration")]
        public long Duration { get; set; }

        /// <summary>
        /// 是否需要效验实例必填项，默认为否
        /// </summary>
        [XmlElement("required_validate")]
        public bool RequiredValidate { get; set; }

        /// <summary>
        /// 下载类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 实例唯一标识
        /// </summary>
        [XmlElement("voucher_id")]
        public string VoucherId { get; set; }
    }
}
