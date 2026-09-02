using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceIotDapplyOrdersimpleinfoBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotDapplyOrdersimpleinfoBatchqueryModel : AopObject
    {
        /// <summary>
        /// 批次申请订单号
        /// </summary>
        [XmlElement("batch_no")]
        public string BatchNo { get; set; }
    }
}
