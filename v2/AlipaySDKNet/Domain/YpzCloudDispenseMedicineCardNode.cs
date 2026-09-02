using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// YpzCloudDispenseMedicineCardNode Data Structure.
    /// </summary>
    [Serializable]
    public class YpzCloudDispenseMedicineCardNode : AopObject
    {
        /// <summary>
        /// 名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 编码
        /// </summary>
        [XmlElement("node_code")]
        public string NodeCode { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
