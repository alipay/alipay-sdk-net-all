using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantSolcreditserviceprodOrderConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantSolcreditserviceprodOrderConfirmModel : AopObject
    {
        /// <summary>
        /// 系统生成订单唯一编号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }
    }
}
