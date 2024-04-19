using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInvoiceInstitutionScopepageinfoQueryResponse.
    /// </summary>
    public class AlipayEbppInvoiceInstitutionScopepageinfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 制度适用范围类型
        /// </summary>
        [XmlElement("adapter_type")]
        public string AdapterType { get; set; }

        /// <summary>
        /// 适配开放id列表
        /// </summary>
        [XmlArray("onwer_open_id_list")]
        [XmlArrayItem("string")]
        public List<string> OnwerOpenIdList { get; set; }

        /// <summary>
        /// 适配id列表
        /// </summary>
        [XmlArray("owner_id_list")]
        [XmlArrayItem("string")]
        public List<string> OwnerIdList { get; set; }

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
        /// 总页数
        /// </summary>
        [XmlElement("total_page_count")]
        public long TotalPageCount { get; set; }
    }
}
