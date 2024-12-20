using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MedicalHealthArchiveOptDTO Data Structure.
    /// </summary>
    [Serializable]
    public class MedicalHealthArchiveOptDTO : AopObject
    {
        /// <summary>
        /// 数据ID
        /// </summary>
        [XmlElement("data_id")]
        public string DataId { get; set; }
    }
}
