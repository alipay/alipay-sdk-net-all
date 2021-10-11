using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Attach Data Structure.
    /// </summary>
    [Serializable]
    public class Attach : AopObject
    {
        /// <summary>
        /// 法务中台文件filekey
        /// </summary>
        [XmlElement("file_location")]
        public string FileLocation { get; set; }

        /// <summary>
        /// 文件名
        /// </summary>
        [XmlElement("file_name")]
        public string FileName { get; set; }
    }
}
