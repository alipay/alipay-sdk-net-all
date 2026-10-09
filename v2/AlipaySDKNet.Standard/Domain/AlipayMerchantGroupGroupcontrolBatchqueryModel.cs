using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantGroupGroupcontrolBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantGroupGroupcontrolBatchqueryModel : AopObject
    {
        /// <summary>
        /// 当前第几页
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页展示条数，最大展示50条
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
