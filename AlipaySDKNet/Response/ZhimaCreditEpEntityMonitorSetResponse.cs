using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpEntityMonitorSetResponse.
    /// </summary>
    public class ZhimaCreditEpEntityMonitorSetResponse : AopResponse
    {
        /// <summary>
        /// 添加成功返回true, 失败返回false
        /// </summary>
        [XmlElement("biz_success")]
        public bool BizSuccess { get; set; }
    }
}
