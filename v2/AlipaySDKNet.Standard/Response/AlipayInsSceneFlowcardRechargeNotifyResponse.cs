using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneFlowcardRechargeNotifyResponse.
    /// </summary>
    public class AlipayInsSceneFlowcardRechargeNotifyResponse : AopResponse
    {
        /// <summary>
        /// 业务单号
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 流量卡iccid
        /// </summary>
        [XmlElement("iccid")]
        public string Iccid { get; set; }
    }
}
