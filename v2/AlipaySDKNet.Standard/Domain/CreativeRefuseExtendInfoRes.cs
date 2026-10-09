using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CreativeRefuseExtendInfoRes Data Structure.
    /// </summary>
    [Serializable]
    public class CreativeRefuseExtendInfoRes : AopObject
    {
        /// <summary>
        /// 审核拒绝的原因文案
        /// </summary>
        [XmlArray("audit_refuse_reason_list")]
        [XmlArrayItem("string")]
        public List<string> AuditRefuseReasonList { get; set; }

        /// <summary>
        /// 审核拒绝图片链接
        /// </summary>
        [XmlArray("image_url_list")]
        [XmlArrayItem("string")]
        public List<string> ImageUrlList { get; set; }
    }
}
