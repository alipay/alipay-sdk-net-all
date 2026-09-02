using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceIotDapplyOrdersnQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotDapplyOrdersnQueryModel : AopObject
    {
        /// <summary>
        /// 设备申请单业务订单号
        /// </summary>
        [XmlElement("order_biz_id")]
        public string OrderBizId { get; set; }
    }
}
