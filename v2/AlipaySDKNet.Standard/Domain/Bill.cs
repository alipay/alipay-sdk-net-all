using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Bill Data Structure.
    /// </summary>
    [Serializable]
    public class Bill : AopObject
    {
        /// <summary>
        /// 出账日期
        /// </summary>
        [XmlElement("bill_date")]
        public string BillDate { get; set; }

        /// <summary>
        /// 账单状态  - OFFSET(已结清)  - CREATE(未结清)  - PAYOUTING(出账中)
        /// </summary>
        [XmlElement("bill_status")]
        public string BillStatus { get; set; }

        /// <summary>
        /// 消费类型  - PREPAY(预付费)  - OFFLINE(后付费)
        /// </summary>
        [XmlElement("bill_type")]
        public string BillType { get; set; }

        /// <summary>
        /// 小程序id
        /// </summary>
        [XmlElement("biz_app_id")]
        public string BizAppId { get; set; }

        /// <summary>
        /// 币种  - CNY  - USD  - EUR
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 优惠金额（分）
        /// </summary>
        [XmlElement("discount_amount")]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// 环境ID
        /// </summary>
        [XmlElement("env_id")]
        public string EnvId { get; set; }

        /// <summary>
        /// 环境名称
        /// </summary>
        [XmlElement("env_name")]
        public string EnvName { get; set; }

        /// <summary>
        /// 计费项名称
        /// </summary>
        [XmlElement("fee_item_name")]
        public string FeeItemName { get; set; }

        /// <summary>
        /// 计费项单位（万次，GB秒，GB天，GB）
        /// </summary>
        [XmlElement("fee_item_unit")]
        public string FeeItemUnit { get; set; }

        /// <summary>
        /// 单价（分）
        /// </summary>
        [XmlElement("original_unit_amount")]
        public string OriginalUnitAmount { get; set; }

        /// <summary>
        /// 欠费金额(分)
        /// </summary>
        [XmlElement("owed_amount")]
        public string OwedAmount { get; set; }

        /// <summary>
        /// 已付金额(分)
        /// </summary>
        [XmlElement("paid_amount")]
        public string PaidAmount { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        [XmlElement("product_name")]
        public string ProductName { get; set; }

        /// <summary>
        /// 应付金额(分) 应付金额 = 已付金额 + 欠费金额
        /// </summary>
        [XmlElement("trade_amount")]
        public string TradeAmount { get; set; }

        /// <summary>
        /// 总价(分) 每天金额明细向下取整后汇总 总价 = 优惠金额 + 应付金额
        /// </summary>
        [XmlElement("trade_total_amount")]
        public string TradeTotalAmount { get; set; }

        /// <summary>
        /// 用量
        /// </summary>
        [XmlElement("usage")]
        public string Usage { get; set; }
    }
}
