using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppJfExternalbillCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppJfExternalbillCreateModel : AopObject
    {
        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 交易申请明细
        /// </summary>
        [XmlElement("order_detail")]
        public PucExternalOrder OrderDetail { get; set; }

        /// <summary>
        /// 用于区分下单来源
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
