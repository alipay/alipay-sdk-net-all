using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoMycarRentcarOrderFinishModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarRentcarOrderFinishModel : AopObject
    {
        /// <summary>
        /// 支付宝用户开放平台id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
