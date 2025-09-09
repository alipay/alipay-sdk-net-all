using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditLoanHonorLendadmitConsultResponse.
    /// </summary>
    public class AlipayPcreditLoanHonorLendadmitConsultResponse : AopResponse
    {
        /// <summary>
        /// 不需要核身，true-跳过核身，false-需要核身 （用于dev mock）
        /// </summary>
        [XmlElement("exempt_verify")]
        public bool ExemptVerify { get; set; }

        /// <summary>
        /// 拒绝原因码（包含风控拒绝），status=1时必传
        /// </summary>
        [XmlElement("refuse_code")]
        public string RefuseCode { get; set; }

        /// <summary>
        /// 拒绝原因说明, status=1时必传
        /// </summary>
        [XmlElement("refuse_msg")]
        public string RefuseMsg { get; set; }

        /// <summary>
        /// 拒绝具体原因说明, status=1时必传
        /// </summary>
        [XmlElement("refuse_msg_data")]
        public string RefuseMsgData { get; set; }

        /// <summary>
        /// 鉴权状态，枚举值： 1-拒绝， 2-通过
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }

        /// <summary>
        /// 核身方式，支用准入后必传，默认返回FACE_CHECK，渠道侧拉起支付宝核身，核身verifyId有效期半小时
        /// </summary>
        [XmlArray("verify_list")]
        [XmlArrayItem("string")]
        public List<string> VerifyList { get; set; }

        /// <summary>
        /// 核身url，支用准入必传，访问此URL进行H5核身
        /// </summary>
        [XmlElement("verify_url")]
        public string VerifyUrl { get; set; }
    }
}
