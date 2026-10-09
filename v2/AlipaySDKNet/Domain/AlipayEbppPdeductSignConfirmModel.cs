using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppPdeductSignConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppPdeductSignConfirmModel : AopObject
    {
        /// <summary>
        /// 机构签约代扣来源渠道 PUBLICPLATFORM：服务窗
        /// </summary>
        [XmlElement("agent_channel")]
        public string AgentChannel { get; set; }

        /// <summary>
        /// 二级渠道码，预留字段
        /// </summary>
        [XmlElement("agent_code")]
        public string AgentCode { get; set; }

        /// <summary>
        /// 户号，机构针对于每户的水、电都会有唯一的标识户号
        /// </summary>
        [XmlElement("bill_key")]
        public string BillKey { get; set; }

        /// <summary>
        /// 支付宝缴费系统中的出账机构ID
        /// </summary>
        [XmlElement("charge_inst")]
        public string ChargeInst { get; set; }

        /// <summary>
        /// 错误编码
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 户号签约失败原因
        /// </summary>
        [XmlElement("error_message")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [XmlElement("extend_field")]
        public string ExtendField { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部产生的协议ID
        /// </summary>
        [XmlElement("out_agreement_id")]
        public string OutAgreementId { get; set; }

        /// <summary>
        /// 商户PartnerId
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 流水号，用于跨系统追踪请求状态，无业务意义
        /// </summary>
        [XmlElement("serial_no")]
        public string SerialNo { get; set; }

        /// <summary>
        /// 签约是否成功，T:成功，F:失败
        /// </summary>
        [XmlElement("sign_result")]
        public string SignResult { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
