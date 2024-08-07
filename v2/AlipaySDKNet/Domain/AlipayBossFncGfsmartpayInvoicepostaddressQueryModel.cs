using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncGfsmartpayInvoicepostaddressQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncGfsmartpayInvoicepostaddressQueryModel : AopObject
    {
        /// <summary>
        /// 业务身份编码
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 公司代码
        /// </summary>
        [XmlElement("company_code")]
        public string CompanyCode { get; set; }

        /// <summary>
        /// ERP实例
        /// </summary>
        [XmlElement("erp_instance")]
        public string ErpInstance { get; set; }

        /// <summary>
        /// 公司ou编码
        /// </summary>
        [XmlElement("ou_code")]
        public string OuCode { get; set; }
    }
}
