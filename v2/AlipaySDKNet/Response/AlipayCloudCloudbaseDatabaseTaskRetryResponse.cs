using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseDatabaseTaskRetryResponse.
    /// </summary>
    public class AlipayCloudCloudbaseDatabaseTaskRetryResponse : AopResponse
    {
        /// <summary>
        /// 云数据库重试任务执行结果
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
