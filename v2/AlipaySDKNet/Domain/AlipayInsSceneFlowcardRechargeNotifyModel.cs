using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneFlowcardRechargeNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneFlowcardRechargeNotifyModel : AopObject
    {
        /// <summary>
        /// 充值业务单号
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 流量卡iccid
        /// </summary>
        [XmlElement("iccid")]
        public string Iccid { get; set; }

        /// <summary>
        /// 充值详情
        /// </summary>
        [XmlElement("recharge_detail")]
        public CardRechargeDetail RechargeDetail { get; set; }
    }
}
