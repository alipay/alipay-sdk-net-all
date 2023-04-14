using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FQExtendParams Data Structure.
    /// </summary>
    [Serializable]
    public class FQExtendParams : AopObject
    {
        /// <summary>
        /// 分期期数
        /// </summary>
        [XmlElement("fq_number")]
        public string FqNumber { get; set; }

        /// <summary>
        /// 表示卖家承担比例
        /// </summary>
        [XmlElement("fq_seller_percent")]
        public string FqSellerPercent { get; set; }
    }
}
