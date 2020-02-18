using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneClaimAttachmentConfirmResponse.
    /// </summary>
    public class AlipayInsSceneClaimAttachmentConfirmResponse : AopResponse
    {
        /// <summary>
        /// 差异的文件清单列表
        /// </summary>
        [XmlArray("lost_files")]
        [XmlArrayItem("string")]
        public List<string> LostFiles { get; set; }

        /// <summary>
        /// 文件上传的状态,清单和实际文件一致的返回SUCCEED，不一致的返回FAIL，同时给出lost_files清单
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
