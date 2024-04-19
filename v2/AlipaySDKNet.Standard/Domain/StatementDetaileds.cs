using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// StatementDetaileds Data Structure.
    /// </summary>
    [Serializable]
    public class StatementDetaileds : AopObject
    {
        /// <summary>
        /// 调整天数
        /// </summary>
        [XmlElement("adjust_days_quantity")]
        public string AdjustDaysQuantity { get; set; }

        /// <summary>
        /// 设备资产id，设备资产登记后返回
        /// </summary>
        [XmlElement("asset_id")]
        public string AssetId { get; set; }

        /// <summary>
        /// 账单天数
        /// </summary>
        [XmlElement("bill_days_quantity")]
        public string BillDaysQuantity { get; set; }

        /// <summary>
        /// 账单结束日期，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("bill_end_date")]
        public string BillEndDate { get; set; }

        /// <summary>
        /// 账单开始日期，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("bill_start_date")]
        public string BillStartDate { get; set; }

        /// <summary>
        /// 合同单价，日单价，单位元
        /// </summary>
        [XmlElement("daily_contract_price")]
        public string DailyContractPrice { get; set; }

        /// <summary>
        /// 进场时间，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("enter_time")]
        public string EnterTime { get; set; }

        /// <summary>
        /// 退场时间，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("exit_time")]
        public string ExitTime { get; set; }

        /// <summary>
        /// 合同单价-运费，单位元
        /// </summary>
        [XmlElement("freight_contract_price")]
        public string FreightContractPrice { get; set; }

        /// <summary>
        /// 维修杂费，单位元
        /// </summary>
        [XmlElement("maintenance_amount")]
        public string MaintenanceAmount { get; set; }

        /// <summary>
        /// 合同单价-月单价，单位元
        /// </summary>
        [XmlElement("month_contract_price")]
        public string MonthContractPrice { get; set; }

        /// <summary>
        /// 实际天数
        /// </summary>
        [XmlElement("real_days_quantity")]
        public string RealDaysQuantity { get; set; }

        /// <summary>
        /// 应收运费，单位元
        /// </summary>
        [XmlElement("receivable_freight")]
        public string ReceivableFreight { get; set; }

        /// <summary>
        /// 改装费，单位元
        /// </summary>
        [XmlElement("refit_amount")]
        public string RefitAmount { get; set; }

        /// <summary>
        /// 租金，单位元
        /// </summary>
        [XmlElement("rent_amount")]
        public string RentAmount { get; set; }

        /// <summary>
        /// 本期合计金额，单位元
        /// </summary>
        [XmlElement("summary_amount")]
        public string SummaryAmount { get; set; }
    }
}
