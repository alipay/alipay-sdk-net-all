using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppInstserviceDeductresultQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInstserviceDeductresultQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝用户的openId
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 申请代扣时的流水号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
