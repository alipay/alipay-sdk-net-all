using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcTransAccountDepositModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcTransAccountDepositModel : AopObject
    {
        /// <summary>
        /// 资金专户账号ID
        /// </summary>
        [XmlElement("account_book_id")]
        public string AccountBookId { get; set; }

        /// <summary>
        /// 充值订单总金额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 企业ID
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 商户端的唯一订单号，对于同一笔充值请求，商户需保证该订单号唯一
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 业务备注
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }
    }
}
