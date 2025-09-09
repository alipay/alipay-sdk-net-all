using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTerminalEdgecloudSwnetflowPoolusageSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTerminalEdgecloudSwnetflowPoolusageSyncModel : AopObject
    {
        /// <summary>
        /// 池套餐周期类型，例如年包，月包
        /// </summary>
        [XmlElement("biling_cycle")]
        public string BilingCycle { get; set; }

        /// <summary>
        /// 池凭证的套餐名称，用于获取档位信息
        /// </summary>
        [XmlElement("credential_name")]
        public string CredentialName { get; set; }

        /// <summary>
        /// 流量的数据类型，例如：单卡通用流量、单卡运营商定向流量
        /// </summary>
        [XmlElement("data_type")]
        public string DataType { get; set; }

        /// <summary>
        /// 流量卡池id
        /// </summary>
        [XmlElement("pool_id")]
        public string PoolId { get; set; }

        /// <summary>
        /// 池剩余流量，单位KB。
        /// </summary>
        [XmlElement("rest_flow")]
        public string RestFlow { get; set; }

        /// <summary>
        /// 池总流量，单位KB。
        /// </summary>
        [XmlElement("total_flow")]
        public string TotalFlow { get; set; }

        /// <summary>
        /// 池使用率，保留2位小数
        /// </summary>
        [XmlElement("usage_ratio")]
        public string UsageRatio { get; set; }
    }
}
