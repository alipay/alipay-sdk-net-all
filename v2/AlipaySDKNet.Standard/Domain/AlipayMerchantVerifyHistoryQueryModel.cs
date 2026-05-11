using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantVerifyHistoryQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantVerifyHistoryQueryModel : AopObject
    {
        /// <summary>
        /// 业务发生时间结束，格式：yyyyMMdd
        /// </summary>
        [XmlElement("gmt_create_end")]
        public string GmtCreateEnd { get; set; }

        /// <summary>
        /// 业务发生时间起始，格式：yyyyMMdd
        /// </summary>
        [XmlElement("gmt_create_start")]
        public string GmtCreateStart { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 每页条数
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("shop_id_list")]
        [XmlArrayItem("string")]
        public List<string> ShopIdList { get; set; }
    }
}
