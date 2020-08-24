using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoContractMessageSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoContractMessageSendModel : AopObject
    {
        /// <summary>
        /// 调用批次号
        /// </summary>
        [XmlElement("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 证件号
        /// </summary>
        [XmlArray("cert_no")]
        [XmlArrayItem("string")]
        public List<string> CertNo { get; set; }

        /// <summary>
        /// 证件类型
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 流程Id
        /// </summary>
        [XmlElement("flow_id")]
        public string FlowId { get; set; }

        /// <summary>
        /// 供应商的appId
        /// </summary>
        [XmlElement("isv_app_id")]
        public string IsvAppId { get; set; }

        /// <summary>
        /// 消息模板ID
        /// </summary>
        [XmlElement("msg_template_id")]
        public string MsgTemplateId { get; set; }

        /// <summary>
        /// 签署平台的代码
        /// </summary>
        [XmlElement("sign_platform_code")]
        public string SignPlatformCode { get; set; }

        /// <summary>
        /// 支付宝账号Id,数组关联多个支付宝账号 （如果未注册支付宝账号 则为空）
        /// </summary>
        [XmlArray("user_ids")]
        [XmlArrayItem("string")]
        public List<string> UserIds { get; set; }
    }
}
