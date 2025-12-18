using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOverseasTaxTaxdataQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasTaxTaxdataQueryModel : AopObject
    {
        /// <summary>
        /// 外部交易单号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }
    }
}
