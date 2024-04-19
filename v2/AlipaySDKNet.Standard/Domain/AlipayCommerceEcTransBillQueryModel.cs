using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcTransBillQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcTransBillQueryModel : AopObject
    {
        /// <summary>
        /// 企业ID
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 该资金专户的业务场景码
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }
    }
}
