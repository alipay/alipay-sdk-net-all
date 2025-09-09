using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayContentCommercialStoreitemBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayContentCommercialStoreitemBatchqueryModel : AopObject
    {
        /// <summary>
        /// 支付宝商品库商品id列表
        /// </summary>
        [XmlArray("item_id_list")]
        [XmlArrayItem("string")]
        public List<string> ItemIdList { get; set; }

        /// <summary>
        /// 支付宝商家pid
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }
    }
}
