using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSpAgentCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSpAgentCreateModel : AopObject
    {
        /// <summary>
        /// 商户支付宝账号
        /// </summary>
        [XmlElement("account")]
        public string Account { get; set; }

        /// <summary>
        /// 智能体描述
        /// </summary>
        [XmlElement("agent_desc")]
        public string AgentDesc { get; set; }

        /// <summary>
        /// 图片格式必须为：png、jpg传入使用 alipay.open.file.upload接口上传图片获取的file_id。
        /// </summary>
        [XmlElement("agent_logo")]
        public string AgentLogo { get; set; }

        /// <summary>
        /// 智能体名称
        /// </summary>
        [XmlElement("agent_name")]
        public string AgentName { get; set; }

        /// <summary>
        /// 营业执照号
        /// </summary>
        [XmlElement("business_license_code")]
        public string BusinessLicenseCode { get; set; }

        /// <summary>
        /// 营业执照名称
        /// </summary>
        [XmlElement("business_license_name")]
        public string BusinessLicenseName { get; set; }

        /// <summary>
        /// [{"name":"工作流构建","value":"WORKFLOW"},{"name":"简单构建","value":"SIMPLE"},{"name":"自主规划","value":"AGENTIC"},{"name":"模板实例化创建","value":"TEMPLATE"}]
        /// </summary>
        [XmlElement("create_type")]
        public string CreateType { get; set; }

        /// <summary>
        /// 商家法人名称
        /// </summary>
        [XmlElement("legal_person_name")]
        public string LegalPersonName { get; set; }

        /// <summary>
        /// 当创建类型为模版实例的时候必填
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
