using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditPeZmgoTemplateCreateResponse.
    /// </summary>
    public class ZhimaCreditPeZmgoTemplateCreateResponse : AopResponse
    {
        /// <summary>
        /// 模板id，创建成功有值
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
