using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InvoiceTitle Data Structure.
    /// </summary>
    [Serializable]
    public class InvoiceTitle : AopObject
    {
        /// <summary>
        /// 小程序云id
        /// </summary>
        [XmlElement("biz_app_id")]
        public string BizAppId { get; set; }

        /// <summary>
        /// 发票抬头基本信息
        /// </summary>
        [XmlElement("invoice_title_info")]
        public InvoiceTitleInfo InvoiceTitleInfo { get; set; }

        /// <summary>
        /// 用户邮件信息列表
        /// </summary>
        [XmlArray("invoice_user_mail_info_orders")]
        [XmlArrayItem("invoice_user_mail_info_order")]
        public List<InvoiceUserMailInfoOrder> InvoiceUserMailInfoOrders { get; set; }
    }
}
