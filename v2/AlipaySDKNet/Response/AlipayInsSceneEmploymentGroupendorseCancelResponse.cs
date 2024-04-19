using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneEmploymentGroupendorseCancelResponse.
    /// </summary>
    public class AlipayInsSceneEmploymentGroupendorseCancelResponse : AopResponse
    {
        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 主批单号
        /// </summary>
        [XmlElement("summary_endorse_order_no")]
        public string SummaryEndorseOrderNo { get; set; }
    }
}
