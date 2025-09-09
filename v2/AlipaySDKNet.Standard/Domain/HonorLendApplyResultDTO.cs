using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HonorLendApplyResultDTO Data Structure.
    /// </summary>
    [Serializable]
    public class HonorLendApplyResultDTO : AopObject
    {
        /// <summary>
        /// 渠道侧借款单号
        /// </summary>
        [XmlElement("apply_no")]
        public string ApplyNo { get; set; }

        /// <summary>
        /// 借款申请状态，枚举值： 2-成功， 3-失败， 4-风控拒绝， 5-取消
        /// </summary>
        [XmlElement("apply_status")]
        public long ApplyStatus { get; set; }

        /// <summary>
        /// 借款申请时间，时间戳毫秒
        /// </summary>
        [XmlElement("apply_time")]
        public long ApplyTime { get; set; }

        /// <summary>
        /// 渠道侧用户id
        /// </summary>
        [XmlElement("channel_customer_id")]
        public string ChannelCustomerId { get; set; }

        /// <summary>
        /// 机构名称
        /// </summary>
        [XmlElement("institution_names")]
        public string InstitutionNames { get; set; }

        /// <summary>
        /// 借款信息 (成功时必传)
        /// </summary>
        [XmlElement("loan_info")]
        public HonorLoanInfoDTO LoanInfo { get; set; }

        /// <summary>
        /// 借款来源, appId（渠道侧提供）
        /// </summary>
        [XmlElement("loan_source")]
        public string LoanSource { get; set; }

        /// <summary>
        /// 随身贷借款受理单号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 拒绝原因，失败或拒绝是必传
        /// </summary>
        [XmlElement("refuse_msg")]
        public string RefuseMsg { get; set; }

        /// <summary>
        /// 拒绝具体原因，失败或拒绝是必传
        /// </summary>
        [XmlElement("refuse_msg_data")]
        public string RefuseMsgData { get; set; }
    }
}
