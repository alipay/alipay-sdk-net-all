using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpSceneTradeConsultResponse.
    /// </summary>
    public class ZhimaCreditEpSceneTradeConsultResponse : AopResponse
    {
        /// <summary>
        /// 评估结果： ACCEPT：没有风险， REJECT：有风险，  REVIEW：需要面签
        /// </summary>
        [XmlElement("decision")]
        public string Decision { get; set; }

        /// <summary>
        /// 芝麻企业信用评估订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 评估结果为REJECT时的原因说明，支持以下原因：SCORE_REJECT ：分数不准入
        /// </summary>
        [XmlElement("reject_reason")]
        public string RejectReason { get; set; }
    }
}
