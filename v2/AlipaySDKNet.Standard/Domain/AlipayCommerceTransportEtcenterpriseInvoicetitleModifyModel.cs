using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportEtcenterpriseInvoicetitleModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportEtcenterpriseInvoicetitleModifyModel : AopObject
    {
        /// <summary>
        /// 虚拟运单编码
        /// </summary>
        [XmlElement("apply_id")]
        public string ApplyId { get; set; }

        /// <summary>
        /// 购方单位地址
        /// </summary>
        [XmlElement("buyer_addr")]
        public string BuyerAddr { get; set; }

        /// <summary>
        /// 购方开户行
        /// </summary>
        [XmlElement("buyer_bank")]
        public string BuyerBank { get; set; }

        /// <summary>
        /// 购方银行账号
        /// </summary>
        [XmlElement("buyer_bank_account")]
        public string BuyerBankAccount { get; set; }

        /// <summary>
        /// 购方客户名称
        /// </summary>
        [XmlElement("buyer_name")]
        public string BuyerName { get; set; }

        /// <summary>
        /// 购方客户名称
        /// </summary>
        [XmlElement("buyer_tax_num")]
        public string BuyerTaxNum { get; set; }

        /// <summary>
        /// 购方电话
        /// </summary>
        [XmlElement("buyer_tel")]
        public string BuyerTel { get; set; }

        /// <summary>
        /// 企业id
        /// </summary>
        [XmlElement("corp_id")]
        public string CorpId { get; set; }

        /// <summary>
        /// 发票接收邮箱
        /// </summary>
        [XmlElement("email")]
        public string Email { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 抬头类型
        /// </summary>
        [XmlElement("title_type")]
        public string TitleType { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
