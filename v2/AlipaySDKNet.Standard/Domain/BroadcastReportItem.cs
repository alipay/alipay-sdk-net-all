using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BroadcastReportItem Data Structure.
    /// </summary>
    [Serializable]
    public class BroadcastReportItem : AopObject
    {
        /// <summary>
        /// 设备激活时间（查询条件，日期选择组件）
        /// </summary>
        [XmlElement("biz_active_time")]
        public string BizActiveTime { get; set; }

        /// <summary>
        /// 设备模式
        /// </summary>
        [XmlElement("coop_mode")]
        public string CoopMode { get; set; }

        /// <summary>
        /// 设备SN
        /// </summary>
        [XmlElement("device_sn")]
        public string DeviceSn { get; set; }

        /// <summary>
        /// 首次营销播报时间（2025年7月1日起首次播报时间）
        /// </summary>
        [XmlElement("first_marketing_broadcast")]
        public string FirstMarketingBroadcast { get; set; }

        /// <summary>
        /// 音箱类型
        /// </summary>
        [XmlElement("is_have_jl_coil")]
        public string IsHaveJlCoil { get; set; }

        /// <summary>
        /// 设备归属服务商pid
        /// </summary>
        [XmlElement("isv_pid")]
        public string IsvPid { get; set; }

        /// <summary>
        /// 商户SMID
        /// </summary>
        [XmlElement("last_bind_merchant_id")]
        public string LastBindMerchantId { get; set; }

        /// <summary>
        /// 当月营销播报次数
        /// </summary>
        [XmlElement("monthly_marketing_count")]
        public long MonthlyMarketingCount { get; set; }

        /// <summary>
        /// 累计有效碰交易笔数
        /// </summary>
        [XmlElement("monthly_touch_tx_count_above_2")]
        public string MonthlyTouchTxCountAbove2 { get; set; }

        /// <summary>
        /// 累计有效交易笔数
        /// </summary>
        [XmlElement("monthly_tx_count_above_2")]
        public long MonthlyTxCountAbove2 { get; set; }

        /// <summary>
        /// 设备外部补充ID
        /// </summary>
        [XmlElement("supplier_id")]
        public string SupplierId { get; set; }

        /// <summary>
        /// 线圈tagid
        /// </summary>
        [XmlElement("tag_id")]
        public string TagId { get; set; }

        /// <summary>
        /// 作业日期范围
        /// </summary>
        [XmlElement("work_date_range")]
        public string WorkDateRange { get; set; }
    }
}
