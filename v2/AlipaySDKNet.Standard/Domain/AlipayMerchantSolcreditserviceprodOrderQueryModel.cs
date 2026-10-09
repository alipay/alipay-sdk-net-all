using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantSolcreditserviceprodOrderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantSolcreditserviceprodOrderQueryModel : AopObject
    {
        /// <summary>
        /// 系统生成订单唯一编号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 商家下单时自定义编号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }
    }
}
