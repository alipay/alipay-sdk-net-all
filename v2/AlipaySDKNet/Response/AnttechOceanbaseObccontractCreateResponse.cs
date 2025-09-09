using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechOceanbaseObccontractCreateResponse.
    /// </summary>
    public class AnttechOceanbaseObccontractCreateResponse : AopResponse
    {
        /// <summary>
        /// 文件地址
        /// </summary>
        [XmlElement("file_url")]
        public string FileUrl { get; set; }

        /// <summary>
        /// 用印流水号
        /// </summary>
        [XmlElement("seal_request_id")]
        public string SealRequestId { get; set; }
    }
}
