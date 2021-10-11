using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceExpensesceneMerchantQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceExpensesceneMerchantQueryModel : AopObject
    {
        /// <summary>
        /// 企业签约企业合花ID-共同账号ID
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 授权签约协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 费用类型 MEAL - 工作餐
        /// </summary>
        [XmlElement("expense_type")]
        public string ExpenseType { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页条数（最大100）
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [XmlElement("role_id")]
        public string RoleId { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
