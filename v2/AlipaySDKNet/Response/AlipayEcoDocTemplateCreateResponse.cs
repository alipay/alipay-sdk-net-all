using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoDocTemplateCreateResponse.
    /// </summary>
    public class AlipayEcoDocTemplateCreateResponse : AopResponse
    {
        /// <summary>
        /// 模板id（请记录模板ID（templateId），后续发起合同签署需要使用到）
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 文件直传地址，需要用此上传地址使用PUT方式上传文件，只有文件上传后模板才可用
        /// </summary>
        [XmlElement("upload_url")]
        public string UploadUrl { get; set; }
    }
}
