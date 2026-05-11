using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalSmsMessageSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalSmsMessageSendModel : AopObject
    {
        /// <summary>
        /// 智能体id
        /// </summary>
        [XmlElement("agent_id")]
        public string AgentId { get; set; }

        /// <summary>
        /// 渠道名称
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 唯一id
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [XmlElement("phone_number")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// 短信模版code
        /// </summary>
        [XmlElement("template")]
        public string Template { get; set; }

        /// <summary>
        /// 模版参数
        /// </summary>
        [XmlElement("template_param")]
        public string TemplateParam { get; set; }
    }
}
