using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AllocDetailDTO Data Structure.
    /// </summary>
    [Serializable]
    public class AllocDetailDTO : AopObject
    {
        /// <summary>
        /// 合花群ID（与当前请求参数中传入值保持一致）
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 自动攒计划的调拨记录的转入金额（单位为元，必须大于0且最多小数点后两位）
        /// </summary>
        [XmlElement("alloc_amount")]
        public string AllocAmount { get; set; }

        /// <summary>
        /// 自动攒计划的调拨记录的错误码
        /// </summary>
        [XmlElement("alloc_error_code")]
        public string AllocErrorCode { get; set; }

        /// <summary>
        /// 自动攒计划的调拨记录的错误描述
        /// </summary>
        [XmlElement("alloc_error_msg")]
        public string AllocErrorMsg { get; set; }

        /// <summary>
        /// 自动攒计划的调拨记录的执行结果<br> - SUCCESS：执行成功<br> - FAIL：执行失败<br> - NO_PROCESS：未执行（如指定付款方资产的可用金额试算不足以完成扣款）
        /// </summary>
        [XmlElement("alloc_status")]
        public string AllocStatus { get; set; }

        /// <summary>
        /// 自动攒计划的调拨记录的实际执行时间（yyyy-MM-dd HH:mm:ss）
        /// </summary>
        [XmlElement("alloc_time")]
        public string AllocTime { get; set; }

        /// <summary>
        /// 自动攒计划的调拨记录的唯一标识（支付宝侧生成）
        /// </summary>
        [XmlElement("detail_id")]
        public string DetailId { get; set; }

        /// <summary>
        /// 当前合花群中的自动攒计划唯一标识（与当前请求参数中传入值保持一致）
        /// </summary>
        [XmlElement("fund_plan_id")]
        public string FundPlanId { get; set; }
    }
}
