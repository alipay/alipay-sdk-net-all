using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCustomerCreditinfoCommentdataSyncResponse.
    /// </summary>
    public class ZhimaCustomerCreditinfoCommentdataSyncResponse : AopResponse
    {
        /// <summary>
        /// 评价数据同步结果
        /// </summary>
        [XmlElement("sync_info")]
        public string SyncInfo { get; set; }
    }
}
