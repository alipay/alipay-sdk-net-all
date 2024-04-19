using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ContractOrderSendLogDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ContractOrderSendLogDTO : AopObject
    {
        /// <summary>
        /// 附件，逗号分隔的ResourceId
        /// </summary>
        [XmlElement("files")]
        public string Files { get; set; }

        /// <summary>
        /// 记录ID
        /// </summary>
        [XmlElement("log_id")]
        public string LogId { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 发送时间
        /// </summary>
        [XmlElement("send_time")]
        public string SendTime { get; set; }

        /// <summary>
        /// 发送人工号
        /// </summary>
        [XmlElement("sender")]
        public string Sender { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
