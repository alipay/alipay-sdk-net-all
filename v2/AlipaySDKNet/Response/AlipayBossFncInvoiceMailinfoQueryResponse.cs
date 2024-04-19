using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossFncInvoiceMailinfoQueryResponse.
    /// </summary>
    public class AlipayBossFncInvoiceMailinfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 创建人
        /// </summary>
        [XmlElement("creator")]
        public string Creator { get; set; }

        /// <summary>
        /// 快递公司名称
        /// </summary>
        [XmlElement("express_company_name")]
        public string ExpressCompanyName { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 发票ID，发票表主键ID，用于关联发票信息
        /// </summary>
        [XmlElement("invoice_id")]
        public string InvoiceId { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        [XmlElement("last_modifier")]
        public string LastModifier { get; set; }

        /// <summary>
        /// 邮寄日期YYYYMMDD
        /// </summary>
        [XmlElement("mail_date")]
        public string MailDate { get; set; }

        /// <summary>
        /// 邮寄ID，唯一性ID，邮寄信息表唯一主键ID
        /// </summary>
        [XmlElement("mail_id")]
        public string MailId { get; set; }

        /// <summary>
        /// 邮寄原因
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// 收件人地址
        /// </summary>
        [XmlElement("recipients_address")]
        public string RecipientsAddress { get; set; }

        /// <summary>
        /// 收件人名称
        /// </summary>
        [XmlElement("recipients_name")]
        public string RecipientsName { get; set; }

        /// <summary>
        /// 收件人电话
        /// </summary>
        [XmlElement("recipients_tel")]
        public string RecipientsTel { get; set; }

        /// <summary>
        /// 寄件人地址
        /// </summary>
        [XmlElement("sender_address")]
        public string SenderAddress { get; set; }

        /// <summary>
        /// 寄件人名称
        /// </summary>
        [XmlElement("sender_name")]
        public string SenderName { get; set; }

        /// <summary>
        /// 寄件人电话
        /// </summary>
        [XmlElement("sender_tel")]
        public string SenderTel { get; set; }

        /// <summary>
        /// 租户ID
        /// </summary>
        [XmlElement("tnt_inst_id")]
        public string TntInstId { get; set; }

        /// <summary>
        /// 快递单号
        /// </summary>
        [XmlElement("tracking_no")]
        public string TrackingNo { get; set; }
    }
}
