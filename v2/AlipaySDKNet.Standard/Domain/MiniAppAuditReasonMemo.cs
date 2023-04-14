using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MiniAppAuditReasonMemo Data Structure.
    /// </summary>
    [Serializable]
    public class MiniAppAuditReasonMemo : AopObject
    {
        /// <summary>
        /// 驳回原因
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 规则图片链接
        /// </summary>
        [XmlArray("memo_image_list")]
        [XmlArrayItem("string")]
        public List<string> MemoImageList { get; set; }
    }
}
