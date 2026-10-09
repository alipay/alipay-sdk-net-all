using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceWithholdTaskCreateResponse.
    /// </summary>
    public class AlipayCommerceWithholdTaskCreateResponse : AopResponse
    {
        /// <summary>
        /// 代扣协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 代扣任务号
        /// </summary>
        [XmlElement("withhold_no")]
        public string WithholdNo { get; set; }
    }
}
