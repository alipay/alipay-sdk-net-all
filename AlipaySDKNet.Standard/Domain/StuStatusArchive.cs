using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// StuStatusArchive Data Structure.
    /// </summary>
    [Serializable]
    public class StuStatusArchive : AopObject
    {
        /// <summary>
        /// 所在学校名称
        /// </summary>
        [XmlElement("inst_name")]
        public string InstName { get; set; }
    }
}
