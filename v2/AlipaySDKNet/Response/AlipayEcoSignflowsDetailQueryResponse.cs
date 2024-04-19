using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoSignflowsDetailQueryResponse.
    /// </summary>
    public class AlipayEcoSignflowsDetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 创建流程时平台上传的附件及签署时用户上传的附件或身份证
        /// </summary>
        [XmlElement("attachments")]
        public AttachmentDetail Attachments { get; set; }

        /// <summary>
        /// 已签署完成文件列表
        /// </summary>
        [XmlElement("docs")]
        public DocInfo Docs { get; set; }
    }
}
