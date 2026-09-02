using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeAgentModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeAgentModifyModel : AopObject
    {
        /// <summary>
        /// 需要修改的支付宝侧智能体唯一ID。
        /// </summary>
        [XmlElement("agent_id")]
        public string AgentId { get; set; }

        /// <summary>
        /// 可解析的json字段，用于填写附加的参数
        /// </summary>
        [XmlElement("attributes")]
        public string Attributes { get; set; }

        /// <summary>
        /// 修改后的智能体载体，取值格式由platform决定。
        /// </summary>
        [XmlElement("carrier")]
        public string Carrier { get; set; }

        /// <summary>
        /// 修改后的智能体Icon，支持AFTS fileId或HTTPS地址。
        /// </summary>
        [XmlElement("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 修改后的智能体对外展示名称。
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 千问平台侧请求唯一标识，用于修改请求幂等和后续查询。
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 商户支付宝登录账号，用于解析商户PID；千问平台PID由OpenAPI调用上下文恢复。
        /// </summary>
        [XmlElement("owner_alipay_account")]
        public string OwnerAlipayAccount { get; set; }

        /// <summary>
        /// 智能体所在端，用于确定carrier的取值格式。
        /// </summary>
        [XmlElement("platform")]
        public string Platform { get; set; }

        /// <summary>
        /// 修改后的智能体简介或副标题，用于KYA展示。
        /// </summary>
        [XmlElement("sub_name")]
        public string SubName { get; set; }
    }
}
