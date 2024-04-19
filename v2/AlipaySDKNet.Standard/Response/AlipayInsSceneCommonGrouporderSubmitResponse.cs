using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneCommonGrouporderSubmitResponse.
    /// </summary>
    public class AlipayInsSceneCommonGrouporderSubmitResponse : AopResponse
    {
        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 主单号
        /// </summary>
        [XmlElement("summary_order_no")]
        public string SummaryOrderNo { get; set; }
    }
}
