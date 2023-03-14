using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneYfxDetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneYfxDetailQueryModel : AopObject
    {
        /// <summary>
        /// 开放平台分配的appid
        /// </summary>
        [XmlElement("app_key")]
        public string AppKey { get; set; }

        /// <summary>
        /// 交易订单号
        /// </summary>
        [XmlElement("biz_order_id")]
        public string BizOrderId { get; set; }

        /// <summary>
        /// 保单号
        /// </summary>
        [XmlElement("policy_no")]
        public string PolicyNo { get; set; }
    }
}
