using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcTransAccountTransferModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcTransAccountTransferModel : AopObject
    {
        /// <summary>
        /// 付款资金专户号
        /// </summary>
        [XmlElement("account_book_id")]
        public string AccountBookId { get; set; }

        /// <summary>
        /// 转账总金额，单位为元，精确到小数点后两位
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 企业ID
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 转账扩展信息，信息会在账单中透出，key支持paymentId:付款事由ruleGroupId:费控规则IDemployeeId:员工ID
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 转账业务的标题，用于在支付宝用户的账单里显示
        /// </summary>
        [XmlElement("order_title")]
        public string OrderTitle { get; set; }

        /// <summary>
        /// 商家侧唯一订单号，由商家自定义。对于不同转账请求，商家需保证该订单号在自身系统唯一
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 收款方信息
        /// </summary>
        [XmlElement("payee_info")]
        public TransParticipant PayeeInfo { get; set; }

        /// <summary>
        /// 在单笔金额超过 50000 的时候必传；
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }
    }
}
