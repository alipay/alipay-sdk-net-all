using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingQualificationDataSyncResponse.
    /// </summary>
    public class AlipayMarketingQualificationDataSyncResponse : AopResponse
    {
        /// <summary>
        /// 本次操作的流水id
        /// </summary>
        [XmlElement("operate_id")]
        public string OperateId { get; set; }
    }
}
