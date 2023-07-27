using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudrunObjectstorageFilelistQueryResponse.
    /// </summary>
    public class AlipayCloudCloudrunObjectstorageFilelistQueryResponse : AopResponse
    {
        /// <summary>
        /// 分页游标下一页标记，文件列表游标索引，next_token为文件分页参数，在本接口的响应中获取，传入next_token以获取下一页数据，若next_token为空代表当前已到页尾，没有下一页
        /// </summary>
        [XmlElement("next_token")]
        public string NextToken { get; set; }

        /// <summary>
        /// 文件列表
        /// </summary>
        [XmlArray("object_list")]
        [XmlArrayItem("oss_object_detail")]
        public List<OssObjectDetail> ObjectList { get; set; }

        /// <summary>
        /// 单页条数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
