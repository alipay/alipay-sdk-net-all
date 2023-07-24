using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundFlexiblestaffingAuthenticationQueryResponse.
    /// </summary>
    public class AlipayFundFlexiblestaffingAuthenticationQueryResponse : AopResponse
    {
        /// <summary>
        /// 商户端的唯一订单号，幂等关键参数。
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 核身结果
        /// </summary>
        [XmlElement("verify_result")]
        public string VerifyResult { get; set; }

        /// <summary>
        /// 核身完成的时间
        /// </summary>
        [XmlElement("verify_time")]
        public string VerifyTime { get; set; }
    }
}
