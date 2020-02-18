using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneApplicationOutsideApplyResponse.
    /// </summary>
    public class AlipayInsSceneApplicationOutsideApplyResponse : AopResponse
    {
        /// <summary>
        /// 外部业务号(与入参调用外部业务号一致)
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 保单号
        /// </summary>
        [XmlElement("policy_no")]
        public string PolicyNo { get; set; }
    }
}
