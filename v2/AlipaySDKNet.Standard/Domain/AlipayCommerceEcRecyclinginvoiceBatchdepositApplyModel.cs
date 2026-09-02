using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcRecyclinginvoiceBatchdepositApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcRecyclinginvoiceBatchdepositApplyModel : AopObject
    {
        /// <summary>
        /// 待出资的订单ID列表
        /// </summary>
        [XmlArray("order_id_list")]
        [XmlArrayItem("string")]
        public List<string> OrderIdList { get; set; }

        /// <summary>
        /// 企业（商户）税号
        /// </summary>
        [XmlElement("tax_no")]
        public string TaxNo { get; set; }
    }
}
