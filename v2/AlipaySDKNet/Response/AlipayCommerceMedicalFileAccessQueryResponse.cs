using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalFileAccessQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalFileAccessQueryResponse : AopResponse
    {
        /// <summary>
        /// 文件临时可访问地址列表
        /// </summary>
        [XmlArray("file_url_list")]
        [XmlArrayItem("string")]
        public List<string> FileUrlList { get; set; }
    }
}
