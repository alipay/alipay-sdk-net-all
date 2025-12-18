using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechOceanbaseObcinfraTasksealApplyResponse.
    /// </summary>
    public class AnttechOceanbaseObcinfraTasksealApplyResponse : AopResponse
    {
        /// <summary>
        /// 用印流水id
        /// </summary>
        [XmlElement("seal_request_id")]
        public string SealRequestId { get; set; }
    }
}
