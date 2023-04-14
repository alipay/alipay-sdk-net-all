using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneProductSignConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneProductSignConfirmModel : AopObject
    {
        /// <summary>
        /// 支付宝会员openID，替代之前传入的2088账号，后续会通过灰度过度不再传入2088，用此id替代
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 产品编码
        /// </summary>
        [XmlElement("prod_code")]
        public string ProdCode { get; set; }

        /// <summary>
        /// 支付宝会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
