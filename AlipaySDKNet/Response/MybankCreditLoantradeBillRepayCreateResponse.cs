using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditLoantradeBillRepayCreateResponse.
    /// </summary>
    public class MybankCreditLoantradeBillRepayCreateResponse : AopResponse
    {
        /// <summary>
        /// 受理成功时有值，trade单据号
        /// </summary>
        [XmlElement("ev_seq_no")]
        public string EvSeqNo { get; set; }

        /// <summary>
        /// 不可见不可用信息
        /// </summary>
        [XmlElement("refuse_msg")]
        public RefuseVo RefuseMsg { get; set; }

        /// <summary>
        /// 是否处理成功，true(成功)，false(失败)。true表示咨询成功，但不代表可见可用
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
