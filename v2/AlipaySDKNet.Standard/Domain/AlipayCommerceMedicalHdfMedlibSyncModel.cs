using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalHdfMedlibSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalHdfMedlibSyncModel : AopObject
    {
        /// <summary>
        /// 内容
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }

        /// <summary>
        /// 操作类型
        /// </summary>
        [XmlElement("op")]
        public string Op { get; set; }

        /// <summary>
        /// 模型的类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
