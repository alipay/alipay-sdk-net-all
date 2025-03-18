using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRentRiskConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRentRiskConsultModel : AopObject
    {
        /// <summary>
        /// 支付宝openid
        /// </summary>
        [XmlElement("alipay_open_id")]
        public string AlipayOpenId { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("consult_risk_types")]
        [XmlArrayItem("string")]
        public List<string> ConsultRiskTypes { get; set; }

        /// <summary>
        /// 商家系统订单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 风险业务场景
        /// </summary>
        [XmlElement("risk_biz_scene")]
        public string RiskBizScene { get; set; }
    }
}
