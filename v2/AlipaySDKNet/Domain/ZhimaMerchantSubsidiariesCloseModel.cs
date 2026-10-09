using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaMerchantSubsidiariesCloseModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaMerchantSubsidiariesCloseModel : AopObject
    {
        /// <summary>
        /// 工单标识
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }
    }
}
