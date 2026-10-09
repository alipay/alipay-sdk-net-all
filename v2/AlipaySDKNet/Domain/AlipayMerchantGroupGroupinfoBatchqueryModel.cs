using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantGroupGroupinfoBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantGroupGroupinfoBatchqueryModel : AopObject
    {
        /// <summary>
        /// 分页页号
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
