using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalMisetorderOrdernoBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalMisetorderOrdernoBatchqueryModel : AopObject
    {
        /// <summary>
        /// 默认值为1
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 默认每页显示20条，最大100
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 日期格式，yyyy-MM-dd
        /// </summary>
        [XmlElement("query_date")]
        public string QueryDate { get; set; }

        /// <summary>
        /// 门店编码
        /// </summary>
        [XmlElement("store_code")]
        public string StoreCode { get; set; }
    }
}
