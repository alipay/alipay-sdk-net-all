using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HonorCreditApplyResultDTO Data Structure.
    /// </summary>
    [Serializable]
    public class HonorCreditApplyResultDTO : AopObject
    {
        /// <summary>
        /// 荣耀侧授信申请流水号
        /// </summary>
        [XmlElement("apply_no")]
        public string ApplyNo { get; set; }

        /// <summary>
        /// 授信结果，1-审核中，2-通过，3-拒绝
        /// </summary>
        [XmlElement("apply_status")]
        public long ApplyStatus { get; set; }

        /// <summary>
        /// 年利率, 示例: 23.4 【即23.4%】(授信通过时返回)
        /// </summary>
        [XmlElement("apr")]
        public string Apr { get; set; }

        /// <summary>
        /// 荣耀方用户id
        /// </summary>
        [XmlElement("channel_customer_id")]
        public string ChannelCustomerId { get; set; }

        /// <summary>
        /// 授信总额度，单位分 (授信通过时返回)
        /// </summary>
        [XmlElement("credit_limit")]
        public string CreditLimit { get; set; }

        /// <summary>
        /// 日利率, 示例: 0.065 【即0.065%】(授信通过时返回, 价格最低产品为日利率时返回)
        /// </summary>
        [XmlElement("day_rate")]
        public string DayRate { get; set; }

        /// <summary>
        /// 额度失效日期, 格式yyyyMMdd
        /// </summary>
        [XmlElement("limit_expire_date")]
        public string LimitExpireDate { get; set; }

        /// <summary>
        /// 额度类型，1-循环额度
        /// </summary>
        [XmlElement("limit_type")]
        public long LimitType { get; set; }

        /// <summary>
        /// 渠道方授信流水号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 拒绝原因码拒绝时必传
        /// </summary>
        [XmlElement("refuse_code")]
        public string RefuseCode { get; set; }

        /// <summary>
        /// 授信拒绝管控期(天)
        /// </summary>
        [XmlElement("refuse_control_time")]
        public long RefuseControlTime { get; set; }

        /// <summary>
        /// 拒绝原因说明拒绝时必传
        /// </summary>
        [XmlElement("refuse_msg")]
        public string RefuseMsg { get; set; }

        /// <summary>
        /// 拒绝原因说明拒绝时必传
        /// </summary>
        [XmlElement("refuse_msg_data")]
        public string RefuseMsgData { get; set; }

        /// <summary>
        /// 可用额度，单位分 (授信通过时返回)
        /// </summary>
        [XmlElement("remain_limit")]
        public string RemainLimit { get; set; }

        /// <summary>
        /// 总可用额度 (临额+固额总和)，单位分 (授信通过时返回)
        /// </summary>
        [XmlElement("total_available_limit")]
        public string TotalAvailableLimit { get; set; }

        /// <summary>
        /// 总授信额度 (临额+固额总和)，单位分 (授信通过时返回)
        /// </summary>
        [XmlElement("total_credit_limit")]
        public string TotalCreditLimit { get; set; }
    }
}
