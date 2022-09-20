using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcConsumeDetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcConsumeDetailQueryModel : AopObject
    {
        /// <summary>
        /// 共同账户ID，有企业ID可不传
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 授权签约协议号，有企业ID可不传
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 企业ID，推荐查询方式
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 支付宝账单号
        /// </summary>
        [XmlElement("pay_no")]
        public string PayNo { get; set; }

        /// <summary>
        /// 查询选项，只针对消费账单生效 查询关联退款账单：Refund 查询关联订单：Order 查询关联票据：Ticket 查询关联多媒体凭证：Multimedia
        /// </summary>
        [XmlArray("query_options")]
        [XmlArrayItem("string")]
        public List<string> QueryOptions { get; set; }
    }
}
