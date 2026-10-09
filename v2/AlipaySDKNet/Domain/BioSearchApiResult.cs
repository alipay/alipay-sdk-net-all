using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BioSearchApiResult Data Structure.
    /// </summary>
    [Serializable]
    public class BioSearchApiResult : AopObject
    {
        /// <summary>
        /// 生物库入库对生物身份定义的ID，在搜索时返回此ID
        /// </summary>
        [XmlElement("face_id")]
        public string FaceId { get; set; }
    }
}
