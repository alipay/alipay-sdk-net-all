using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AttachmentExplain Data Structure.
    /// </summary>
    [Serializable]
    public class AttachmentExplain : AopObject
    {
        /// <summary>
        /// 是否允许上传更多附件 （collect_attachement值为true时必填）
        /// </summary>
        [XmlElement("allow_more_uploads")]
        public bool AllowMoreUploads { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 附件列表
        /// </summary>
        [XmlArray("details")]
        [XmlArrayItem("detail")]
        public List<Detail> Details { get; set; }

        /// <summary>
        /// 附件标题（collect_attachement值为true时必填
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
