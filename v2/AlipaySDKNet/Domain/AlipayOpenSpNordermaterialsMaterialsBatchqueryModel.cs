using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSpNordermaterialsMaterialsBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSpNordermaterialsMaterialsBatchqueryModel : AopObject
    {
        /// <summary>
        /// 分批查询的页码，必填
        /// </summary>
        [XmlElement("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 每页的数据量大小，单位条
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// spi收到的生产单号对应
        /// </summary>
        [XmlElement("production_order_no")]
        public string ProductionOrderNo { get; set; }
    }
}
