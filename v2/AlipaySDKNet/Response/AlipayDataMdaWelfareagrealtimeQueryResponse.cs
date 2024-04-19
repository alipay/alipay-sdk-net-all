using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataMdaWelfareagrealtimeQueryResponse.
    /// </summary>
    public class AlipayDataMdaWelfareagrealtimeQueryResponse : AopResponse
    {
        /// <summary>
        /// 今日完成火苗捐赠人数
        /// </summary>
        [XmlElement("total_donate")]
        public long TotalDonate { get; set; }

        /// <summary>
        /// 今日获取火苗人数
        /// </summary>
        [XmlElement("total_obtain")]
        public long TotalObtain { get; set; }
    }
}
