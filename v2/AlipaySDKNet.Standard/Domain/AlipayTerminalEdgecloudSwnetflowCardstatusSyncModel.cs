using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTerminalEdgecloudSwnetflowCardstatusSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTerminalEdgecloudSwnetflowCardstatusSyncModel : AopObject
    {
        /// <summary>
        /// 变更后卡流量状态
        /// </summary>
        [XmlElement("after_os_status")]
        public string AfterOsStatus { get; set; }

        /// <summary>
        /// 变更后卡状态
        /// </summary>
        [XmlElement("after_status")]
        public string AfterStatus { get; set; }

        /// <summary>
        /// 变更前卡流量状态
        /// </summary>
        [XmlElement("before_os_status")]
        public string BeforeOsStatus { get; set; }

        /// <summary>
        /// 变更前卡状态
        /// </summary>
        [XmlElement("before_status")]
        public string BeforeStatus { get; set; }

        /// <summary>
        /// 卡套餐周期类型，例如年包-ANNUAL，月包-MONTH
        /// </summary>
        [XmlElement("biling_cycle")]
        public string BilingCycle { get; set; }

        /// <summary>
        /// 卡所属池凭证的套餐名称
        /// </summary>
        [XmlElement("credential_name")]
        public string CredentialName { get; set; }

        /// <summary>
        /// 卡流量的数据类型，例如：单卡通用流量、单卡运营商定向流量
        /// </summary>
        [XmlElement("data_type")]
        public string DataType { get; set; }

        /// <summary>
        /// 流量卡唯一标识iccid
        /// </summary>
        [XmlElement("icc_id")]
        public string IccId { get; set; }
    }
}
