using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusResourceUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataAiserviceCloudbusResourceUploadModel : AopObject
    {
        /// <summary>
        /// 内容字段
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }

        /// <summary>
        /// 资源名称
        /// </summary>
        [XmlElement("res_name")]
        public string ResName { get; set; }

        /// <summary>
        /// 资源类型
        /// </summary>
        [XmlElement("type")]
        public long Type { get; set; }
    }
}
