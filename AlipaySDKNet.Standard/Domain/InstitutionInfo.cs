using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InstitutionInfo Data Structure.
    /// </summary>
    [Serializable]
    public class InstitutionInfo : AopObject
    {
        /// <summary>
        /// 期望入库时间 不传则立即入库
        /// </summary>
        [XmlElement("face_in_time")]
        public string FaceInTime { get; set; }

        /// <summary>
        /// 机构ID
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }
    }
}
