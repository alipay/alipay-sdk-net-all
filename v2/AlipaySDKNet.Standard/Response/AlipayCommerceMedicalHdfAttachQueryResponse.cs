using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalHdfAttachQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalHdfAttachQueryResponse : AopResponse
    {
        /// <summary>
        /// 附件Id
        /// </summary>
        [XmlElement("attachement_id")]
        public string AttachementId { get; set; }

        /// <summary>
        /// 路径
        /// </summary>
        [XmlElement("file_path")]
        public string FilePath { get; set; }

        /// <summary>
        /// 链接
        /// </summary>
        [XmlElement("murl")]
        public string Murl { get; set; }

        /// <summary>
        /// 链接
        /// </summary>
        [XmlElement("nurl")]
        public string Nurl { get; set; }

        /// <summary>
        /// 链接
        /// </summary>
        [XmlElement("turl")]
        public string Turl { get; set; }

        /// <summary>
        /// 链接
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
