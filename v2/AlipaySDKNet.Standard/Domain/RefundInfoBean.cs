using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RefundInfoBean Data Structure.
    /// </summary>
    [Serializable]
    public class RefundInfoBean : AopObject
    {
        /// <summary>
        /// 实际退款金额，单位：元
        /// </summary>
        [XmlElement("actual_ref_amt")]
        public string ActualRefAmt { get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        [XmlElement("mer_name")]
        public string MerName { get; set; }

        /// <summary>
        /// 申请退款金额，单元：元
        /// </summary>
        [XmlElement("ord_amt")]
        public string OrdAmt { get; set; }

        /// <summary>
        /// 原交易请求流水号
        /// </summary>
        [XmlElement("org_req_seq_id")]
        public string OrgReqSeqId { get; set; }

        /// <summary>
        /// 请求流水号
        /// </summary>
        [XmlElement("req_seq_id")]
        public string ReqSeqId { get; set; }

        /// <summary>
        /// 当前场景，此处填写huifu_id，跟thirdpay_org联动
        /// </summary>
        [XmlElement("thirdpay_mer_id")]
        public string ThirdpayMerId { get; set; }

        /// <summary>
        /// 第三方支付机构，当前场景为huifu
        /// </summary>
        [XmlElement("thirdpay_org")]
        public string ThirdpayOrg { get; set; }

        /// <summary>
        /// 退款交易完成时间，格式yyyyMMddHHmmss；示例值：20091225091010
        /// </summary>
        [XmlElement("trans_finish_time")]
        public string TransFinishTime { get; set; }

        /// <summary>
        /// 退款交易发生时间,格式：HHMMSS
        /// </summary>
        [XmlElement("trans_time")]
        public string TransTime { get; set; }
    }
}
