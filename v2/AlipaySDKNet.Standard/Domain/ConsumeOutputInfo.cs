using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ConsumeOutputInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ConsumeOutputInfo : AopObject
    {
        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 账单分类
        /// </summary>
        [XmlElement("category_name")]
        public string CategoryName { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        [XmlElement("consume_amount")]
        public string ConsumeAmount { get; set; }

        /// <summary>
        /// 日期
        /// </summary>
        [XmlElement("consume_date")]
        public string ConsumeDate { get; set; }

        /// <summary>
        /// 交易记录标题
        /// </summary>
        [XmlElement("consume_title")]
        public string ConsumeTitle { get; set; }

        /// <summary>
        /// 商家名称
        /// </summary>
        [XmlElement("payee_name")]
        public string PayeeName { get; set; }
    }
}
