using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniCloudFilelistQueryResponse.
    /// </summary>
    public class AlipayOpenMiniCloudFilelistQueryResponse : AopResponse
    {
        /// <summary>
        /// 文件列表
        /// </summary>
        [XmlArray("file_base_info_response_list")]
        [XmlArrayItem("file_base_info_response")]
        public List<FileBaseInfoResponse> FileBaseInfoResponseList { get; set; }

        /// <summary>
        /// 文件列表游标索引
        /// </summary>
        [XmlElement("next_token")]
        public string NextToken { get; set; }

        /// <summary>
        /// 本次查询返回的列表长度
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
