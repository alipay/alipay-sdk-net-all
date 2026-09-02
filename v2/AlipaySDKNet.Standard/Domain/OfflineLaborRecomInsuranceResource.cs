using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OfflineLaborRecomInsuranceResource Data Structure.
    /// </summary>
    [Serializable]
    public class OfflineLaborRecomInsuranceResource : AopObject
    {
        /// <summary>
        /// 投保须知
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 资源名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 资源类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 资源内容
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
