using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingQualificationDataUploadResponse.
    /// </summary>
    public class AlipayMarketingQualificationDataUploadResponse : AopResponse
    {
        /// <summary>
        /// 操作流水id
        /// </summary>
        [XmlElement("operate_id")]
        public string OperateId { get; set; }
    }
}
