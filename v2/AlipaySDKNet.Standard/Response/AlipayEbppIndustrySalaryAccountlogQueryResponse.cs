using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustrySalaryAccountlogQueryResponse.
    /// </summary>
    public class AlipayEbppIndustrySalaryAccountlogQueryResponse : AopResponse
    {
        /// <summary>
        /// 本次分页账务内容
        /// </summary>
        [XmlArray("account_log_list")]
        [XmlArrayItem("account_log_list_d_t_o")]
        public List<AccountLogListDTO> AccountLogList { get; set; }

        /// <summary>
        /// 页数
        /// </summary>
        [XmlElement("page_no")]
        public string PageNo { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 响应加签xml，通过base64加签
        /// </summary>
        [XmlElement("sign_xml")]
        public string SignXml { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [XmlElement("total")]
        public string Total { get; set; }
    }
}
