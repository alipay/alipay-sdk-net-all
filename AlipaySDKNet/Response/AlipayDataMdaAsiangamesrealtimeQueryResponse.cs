using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataMdaAsiangamesrealtimeQueryResponse.
    /// </summary>
    public class AlipayDataMdaAsiangamesrealtimeQueryResponse : AopResponse
    {
        /// <summary>
        /// 今日亚运路线完成人数
        /// </summary>
        [XmlElement("completed")]
        public long Completed { get; set; }

        /// <summary>
        /// 今日亚运路线参与人数
        /// </summary>
        [XmlElement("dau")]
        public long Dau { get; set; }
    }
}
