using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFincoreComplianceTemplateInstanceCreateResponse.
    /// </summary>
    public class AlipayFincoreComplianceTemplateInstanceCreateResponse : AopResponse
    {
        /// <summary>
        /// 模版业务实例id
        /// </summary>
        [XmlElement("biz_instance_id")]
        public string BizInstanceId { get; set; }
    }
}
