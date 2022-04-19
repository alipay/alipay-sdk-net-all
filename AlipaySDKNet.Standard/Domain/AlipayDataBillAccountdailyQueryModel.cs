using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataBillAccountdailyQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataBillAccountdailyQueryModel : AopObject
    {
        /// <summary>
        /// 签约授权协议号。特殊场景使用
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 签约授权产品码。特殊场景使用
        /// </summary>
        [XmlElement("agreement_product_code")]
        public string AgreementProductCode { get; set; }

        /// <summary>
        /// 查询的目标账号。余额户为2088+0156；支出户/收入户为特定的271/281账号
        /// </summary>
        [XmlElement("bill_user_account_no")]
        public string BillUserAccountNo { get; set; }

        /// <summary>
        /// 指定查询支付宝账户id
        /// </summary>
        [XmlElement("bill_user_id")]
        public string BillUserId { get; set; }

        /// <summary>
        /// 查询的日期，需要小于请求当天
        /// </summary>
        [XmlElement("date")]
        public string Date { get; set; }
    }
}
