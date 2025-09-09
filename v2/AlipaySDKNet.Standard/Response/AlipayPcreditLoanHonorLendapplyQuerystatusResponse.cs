using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditLoanHonorLendapplyQuerystatusResponse.
    /// </summary>
    public class AlipayPcreditLoanHonorLendapplyQuerystatusResponse : AopResponse
    {
        /// <summary>
        /// 借款申请状态，枚举值： 1-审核中，2-成功，3-失败
        /// </summary>
        [XmlElement("apply_status")]
        public long ApplyStatus { get; set; }

        /// <summary>
        /// 借款申请时间，时间戳毫秒
        /// </summary>
        [XmlElement("apply_time")]
        public long ApplyTime { get; set; }

        /// <summary>
        /// 机构名称（简称），放款后需要对客展示的，不能脱敏
        /// </summary>
        [XmlElement("institution_names")]
        public string InstitutionNames { get; set; }

        /// <summary>
        /// 随身贷支用受理单号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 拒绝原因码（失败必传）
        /// </summary>
        [XmlElement("refuse_code")]
        public string RefuseCode { get; set; }

        /// <summary>
        /// 拒绝原因说明（失败必传）
        /// </summary>
        [XmlElement("refuse_msg")]
        public string RefuseMsg { get; set; }

        /// <summary>
        /// 拒绝具体原因描述（失败必传）
        /// </summary>
        [XmlElement("refuse_msg_data")]
        public string RefuseMsgData { get; set; }
    }
}
