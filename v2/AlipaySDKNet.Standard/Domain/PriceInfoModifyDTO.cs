using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PriceInfoModifyDTO Data Structure.
    /// </summary>
    [Serializable]
    public class PriceInfoModifyDTO : AopObject
    {
        /// <summary>
        /// 订单金额，单位：元
        /// </summary>
        [XmlElement("order_price")]
        public string OrderPrice { get; set; }

        /// <summary>
        /// 订单的真实金额，适用于下单时不能确定实际金额的场景，单位为元
        /// </summary>
        [XmlElement("real_order_price")]
        public string RealOrderPrice { get; set; }
    }
}
