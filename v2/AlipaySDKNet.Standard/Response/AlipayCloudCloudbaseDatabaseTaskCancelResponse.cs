using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseDatabaseTaskCancelResponse.
    /// </summary>
    public class AlipayCloudCloudbaseDatabaseTaskCancelResponse : AopResponse
    {
        /// <summary>
        /// 取消任务执行结果
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
