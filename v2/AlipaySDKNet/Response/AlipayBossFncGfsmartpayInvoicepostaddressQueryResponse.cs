using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossFncGfsmartpayInvoicepostaddressQueryResponse.
    /// </summary>
    public class AlipayBossFncGfsmartpayInvoicepostaddressQueryResponse : AopResponse
    {
        /// <summary>
        /// 地址名称
        /// </summary>
        [XmlElement("address_name")]
        public string AddressName { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        [XmlElement("address_phone")]
        public string AddressPhone { get; set; }

        /// <summary>
        /// 联系邮箱
        /// </summary>
        [XmlElement("contact_email")]
        public string ContactEmail { get; set; }

        /// <summary>
        /// 大陆发票邮箱
        /// </summary>
        [XmlElement("mainland_invoice_post_email")]
        public string MainlandInvoicePostEmail { get; set; }

        /// <summary>
        /// 海外发票邮箱
        /// </summary>
        [XmlElement("oversea_invoice_post_email")]
        public string OverseaInvoicePostEmail { get; set; }

        /// <summary>
        /// 邮寄地址
        /// </summary>
        [XmlElement("post_address")]
        public string PostAddress { get; set; }
    }
}
