using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditLoanHonorCreditApplyResponse.
    /// </summary>
    public class AlipayPcreditLoanHonorCreditApplyResponse : AopResponse
    {
        /// <summary>
        /// 授信结果，1-审核中，2-通过，3-拒绝
        /// </summary>
        [XmlElement("apply_status")]
        public long ApplyStatus { get; set; }

        /// <summary>
        /// 渠道方授信流水号(授信审核中或通过时必传)
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 拒绝原因码
        /// </summary>
        [XmlElement("refuse_code")]
        public string RefuseCode { get; set; }

        /// <summary>
        /// 授信拒绝管控期，单位：秒，天
        /// </summary>
        [XmlElement("refuse_control_time")]
        public long RefuseControlTime { get; set; }

        /// <summary>
        /// 拒绝原因说明
        /// </summary>
        [XmlElement("refuse_msg")]
        public string RefuseMsg { get; set; }

        /// <summary>
        /// 拒绝具体原因说明
        /// </summary>
        [XmlElement("refuse_msg_data")]
        public string RefuseMsgData { get; set; }
    }
}
