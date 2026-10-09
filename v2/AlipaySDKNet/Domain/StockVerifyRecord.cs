using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// StockVerifyRecord Data Structure.
    /// </summary>
    [Serializable]
    public class StockVerifyRecord : AopObject
    {
        /// <summary>
        /// 核对不一致-总数
        /// </summary>
        [XmlElement("diff_count")]
        public long DiffCount { get; set; }

        /// <summary>
        /// 核对不一致-相关离线总金额
        /// </summary>
        [XmlElement("diff_offline_amt")]
        public string DiffOfflineAmt { get; set; }

        /// <summary>
        /// 核对不一致-相关在线总金额
        /// </summary>
        [XmlElement("diff_online_amt")]
        public string DiffOnlineAmt { get; set; }

        /// <summary>
        /// 离线缺数据-总数
        /// </summary>
        [XmlElement("offline_miss_count")]
        public long OfflineMissCount { get; set; }

        /// <summary>
        /// 离线缺数据-相关在线总金额
        /// </summary>
        [XmlElement("offline_miss_online_amt")]
        public string OfflineMissOnlineAmt { get; set; }

        /// <summary>
        /// 在线缺失-总数
        /// </summary>
        [XmlElement("online_miss_count")]
        public string OnlineMissCount { get; set; }

        /// <summary>
        /// 在线缺失数据-相关离线总金额
        /// </summary>
        [XmlElement("online_miss_offline_amt")]
        public string OnlineMissOfflineAmt { get; set; }

        /// <summary>
        /// 成功总金额
        /// </summary>
        [XmlElement("success_amt")]
        public string SuccessAmt { get; set; }

        /// <summary>
        /// 核对成功总数
        /// </summary>
        [XmlElement("success_count")]
        public long SuccessCount { get; set; }

        /// <summary>
        /// 核对日期
        /// </summary>
        [XmlElement("verify_date")]
        public string VerifyDate { get; set; }
    }
}
