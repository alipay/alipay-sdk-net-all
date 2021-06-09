using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneApplicationMobileApplyResponse.
    /// </summary>
    public class AlipayInsSceneApplicationMobileApplyResponse : AopResponse
    {
        /// <summary>
        /// 保障卡短连
        /// </summary>
        [XmlElement("card_url")]
        public string CardUrl { get; set; }

        /// <summary>
        /// 外部商户业务ID，必须唯一
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 保险保单号
        /// </summary>
        [XmlElement("policy_no")]
        public string PolicyNo { get; set; }
    }
}
