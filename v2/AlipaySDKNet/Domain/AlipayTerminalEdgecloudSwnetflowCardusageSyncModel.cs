using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTerminalEdgecloudSwnetflowCardusageSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTerminalEdgecloudSwnetflowCardusageSyncModel : AopObject
    {
        /// <summary>
        /// 上次同步时日流量，单位KB
        /// </summary>
        [XmlElement("before_day_usage")]
        public string BeforeDayUsage { get; set; }

        /// <summary>
        /// 上次同步月流量，单位KB。
        /// </summary>
        [XmlElement("before_month_usage")]
        public string BeforeMonthUsage { get; set; }

        /// <summary>
        /// 卡池套餐周期，例如年包，月包
        /// </summary>
        [XmlElement("biling_cycle")]
        public string BilingCycle { get; set; }

        /// <summary>
        /// 卡池套餐名称，包含档位信息
        /// </summary>
        [XmlElement("credential_name")]
        public string CredentialName { get; set; }

        /// <summary>
        /// 当前日流量，单位KB。
        /// </summary>
        [XmlElement("current_day_usage")]
        public string CurrentDayUsage { get; set; }

        /// <summary>
        /// 当前月流量，单位KB。
        /// </summary>
        [XmlElement("current_month_usage")]
        public string CurrentMonthUsage { get; set; }

        /// <summary>
        /// 卡池套餐档位信息，例如：单卡通用流量、单卡运营商定向流量
        /// </summary>
        [XmlElement("data_type")]
        public string DataType { get; set; }

        /// <summary>
        /// 流量卡id
        /// </summary>
        [XmlElement("icc_id")]
        public string IccId { get; set; }
    }
}
