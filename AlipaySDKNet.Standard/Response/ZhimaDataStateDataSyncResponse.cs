using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaDataStateDataSyncResponse.
    /// </summary>
    public class ZhimaDataStateDataSyncResponse : AopResponse
    {
        /// <summary>
        /// 同步结果成功或失败,具体错误码在错误信息中
        /// </summary>
        [XmlElement("biz_result")]
        public string BizResult { get; set; }
    }
}
