using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTerminalEdgecloudSwnetflowCardfullSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTerminalEdgecloudSwnetflowCardfullSyncModel : AopObject
    {
        /// <summary>
        /// 卡激活时间
        /// </summary>
        [XmlElement("active_time")]
        public string ActiveTime { get; set; }

        /// <summary>
        /// 卡池套餐周期，例如年包，月包
        /// </summary>
        [XmlElement("biling_cycle")]
        public string BilingCycle { get; set; }

        /// <summary>
        /// 卡状态
        /// </summary>
        [XmlElement("card_status")]
        public string CardStatus { get; set; }

        /// <summary>
        /// 流量卡套餐名称，用于获取档位信息
        /// </summary>
        [XmlElement("credential_name")]
        public string CredentialName { get; set; }

        /// <summary>
        /// 卡池套餐档位信息，例如：单卡通用流量、单卡运营商定向流量
        /// </summary>
        [XmlElement("data_type")]
        public string DataType { get; set; }

        /// <summary>
        /// 卡销户时间
        /// </summary>
        [XmlElement("destroy_time")]
        public string DestroyTime { get; set; }

        /// <summary>
        /// 流量状态
        /// </summary>
        [XmlElement("gprs_status")]
        public string GprsStatus { get; set; }

        /// <summary>
        /// 流量卡id
        /// </summary>
        [XmlElement("icc_id")]
        public string IccId { get; set; }

        /// <summary>
        /// 设备IMEI
        /// </summary>
        [XmlElement("imei")]
        public string Imei { get; set; }

        /// <summary>
        /// 流量是否超标
        /// </summary>
        [XmlElement("is_over_limit")]
        public string IsOverLimit { get; set; }

        /// <summary>
        /// 套餐到期时间
        /// </summary>
        [XmlElement("last_stop_date")]
        public string LastStopDate { get; set; }

        /// <summary>
        /// 卡的网络状态
        /// </summary>
        [XmlElement("os_status")]
        public string OsStatus { get; set; }

        /// <summary>
        /// 流量卡池id
        /// </summary>
        [XmlElement("pool_id")]
        public string PoolId { get; set; }

        /// <summary>
        /// 用户查询尚闻订单唯一表示标识
        /// </summary>
        [XmlElement("sw_order_id")]
        public string SwOrderId { get; set; }

        /// <summary>
        /// 卡总流量，单位KB。
        /// </summary>
        [XmlElement("total_flow_amount")]
        public string TotalFlowAmount { get; set; }

        /// <summary>
        /// 卡运营商
        /// </summary>
        [XmlElement("vendor_id")]
        public string VendorId { get; set; }
    }
}
