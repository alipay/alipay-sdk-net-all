using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceHousingApartmentBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceHousingApartmentBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 返回结果
        /// </summary>
        [XmlElement("list")]
        public ApartmentModelDTO List { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
