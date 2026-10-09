using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneClaimApplyResponse.
    /// </summary>
    public class AlipayInsSceneClaimApplyResponse : AopResponse
    {
        /// <summary>
        /// 报案号
        /// </summary>
        [XmlElement("claim_report_no")]
        public string ClaimReportNo { get; set; }

        /// <summary>
        /// 商户生成的外部投保业务号,必须保证唯一
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 商户生成的理赔请求单号【幂等字段】
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }
    }
}
