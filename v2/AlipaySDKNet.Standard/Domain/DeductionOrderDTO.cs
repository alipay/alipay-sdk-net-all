using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeductionOrderDTO Data Structure.
    /// </summary>
    [Serializable]
    public class DeductionOrderDTO : AopObject
    {
        /// <summary>
        /// 实支付时间
        /// </summary>
        [XmlElement("actual_deduction_time")]
        public string ActualDeductionTime { get; set; }

        /// <summary>
        /// 扣款单取消时间
        /// </summary>
        [XmlElement("cancel_time")]
        public string CancelTime { get; set; }

        /// <summary>
        /// 扣款单对应扣款金额
        /// </summary>
        [XmlElement("deduction_amount")]
        public string DeductionAmount { get; set; }

        /// <summary>
        /// 扣款失败原因
        /// </summary>
        [XmlElement("deduction_fail_reason")]
        public string DeductionFailReason { get; set; }

        /// <summary>
        /// 系统生成扣款单唯一编号
        /// </summary>
        [XmlElement("deduction_order_no")]
        public string DeductionOrderNo { get; set; }

        /// <summary>
        /// PAID 初始化: INIT 支付中: PAYING 已支付: PAID 支付失败: PAY_FAILED 已取消: CANCEL 全额退款: FULLY_REFUNDED
        /// </summary>
        [XmlElement("deduction_order_status")]
        public string DeductionOrderStatus { get; set; }

        /// <summary>
        /// 押金扣款单: DEPOSIT 租金扣款单: RENT
        /// </summary>
        [XmlElement("deduction_order_type")]
        public string DeductionOrderType { get; set; }

        /// <summary>
        /// 【押金扣款】单填写
        /// </summary>
        [XmlElement("deduction_reason")]
        public string DeductionReason { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 系统生成订单唯一编号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 系统扣款: SYSTEM 用户手动扣款: USER
        /// </summary>
        [XmlElement("pay_channel")]
        public string PayChannel { get; set; }

        /// <summary>
        /// 【周期付】信用服务类型填写
        /// </summary>
        [XmlElement("period_num")]
        public long PeriodNum { get; set; }

        /// <summary>
        /// 该时间用于到期扣款与扣款失败重试扣款
        /// </summary>
        [XmlElement("plan_deduction_time")]
        public string PlanDeductionTime { get; set; }

        /// <summary>
        /// 系统生成的商品编号
        /// </summary>
        [XmlElement("product_no")]
        public string ProductNo { get; set; }

        /// <summary>
        /// 退款成功记录列表
        /// </summary>
        [XmlArray("refunded_record_list")]
        [XmlArrayItem("refunded_record_list_d_t_o")]
        public List<RefundedRecordListDTO> RefundedRecordList { get; set; }

        /// <summary>
        /// 分账详情列表
        /// </summary>
        [XmlArray("settle_info_list")]
        [XmlArrayItem("settle_info_list_d_t_o")]
        public List<SettleInfoListDTO> SettleInfoList { get; set; }

        /// <summary>
        /// 直付通进件得到的ID
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("u_open_id")]
        public string UOpenId { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
