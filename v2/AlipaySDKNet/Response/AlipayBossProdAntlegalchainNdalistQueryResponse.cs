using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossProdAntlegalchainNdalistQueryResponse.
    /// </summary>
    public class AlipayBossProdAntlegalchainNdalistQueryResponse : AopResponse
    {
        /// <summary>
        /// 每页条数
        /// </summary>
        [XmlElement("items_per_page")]
        public long ItemsPerPage { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("page")]
        public long Page { get; set; }

        /// <summary>
        /// NDA协议签约记录结果
        /// </summary>
        [XmlArray("page_list")]
        [XmlArrayItem("antlc_nda_protocol_sign_record_ext_d_o")]
        public List<AntlcNdaProtocolSignRecordExtDO> PageList { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        [XmlElement("total_items")]
        public long TotalItems { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [XmlElement("total_pages")]
        public long TotalPages { get; set; }
    }
}
