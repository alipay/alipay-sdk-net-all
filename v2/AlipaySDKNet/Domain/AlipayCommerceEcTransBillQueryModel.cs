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
        /// 资金专户账号ID
        /// </summary>
        [XmlElement("account_book_id")]
        public string AccountBookId { get; set; }

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
        /// 该资金专户的业务场景码 当前字段已废弃(入参中scene易理解，使用资金专户ID（account_book_id）替代)
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }
    }
}
