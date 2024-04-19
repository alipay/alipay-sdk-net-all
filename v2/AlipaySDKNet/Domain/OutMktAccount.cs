using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OutMktAccount Data Structure.
    /// </summary>
    [Serializable]
    public class OutMktAccount : AopObject
    {
        /// <summary>
        /// 营销账号id
        /// </summary>
        [XmlElement("mkt_owner_id")]
        public string MktOwnerId { get; set; }

        /// <summary>
        /// 营销账号名
        /// </summary>
        [XmlElement("mkt_owner_name")]
        public string MktOwnerName { get; set; }

        /// <summary>
        /// 外部操作员列表
        /// </summary>
        [XmlArray("out_operators")]
        [XmlArrayItem("out_operator")]
        public List<OutOperator> OutOperators { get; set; }

        /// <summary>
        /// 支付账号id
        /// </summary>
        [XmlElement("payment_owner_id")]
        public string PaymentOwnerId { get; set; }

        /// <summary>
        /// 支付账号名
        /// </summary>
        [XmlElement("payment_owner_name")]
        public string PaymentOwnerName { get; set; }
    }
}
