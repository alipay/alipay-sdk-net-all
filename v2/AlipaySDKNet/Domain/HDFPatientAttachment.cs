using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HDFPatientAttachment Data Structure.
    /// </summary>
    [Serializable]
    public class HDFPatientAttachment : AopObject
    {
        /// <summary>
        /// 附件的文件类型。如，png、pdf
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 好大夫的图片url
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
