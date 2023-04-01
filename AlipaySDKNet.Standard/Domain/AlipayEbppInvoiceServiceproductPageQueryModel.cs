using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceServiceproductPageQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceServiceproductPageQueryModel : AopObject
    {
        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 页码大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 费用子类型
        /// </summary>
        [XmlElement("service_expense_sub_type")]
        public string ServiceExpenseSubType { get; set; }
    }
}
