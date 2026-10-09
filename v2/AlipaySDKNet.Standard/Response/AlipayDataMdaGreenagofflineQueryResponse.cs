using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataMdaGreenagofflineQueryResponse.
    /// </summary>
    public class AlipayDataMdaGreenagofflineQueryResponse : AopResponse
    {
        /// <summary>
        /// 完成公益任务人数
        /// </summary>
        [XmlElement("completed_cnt")]
        public long CompletedCnt { get; set; }

        /// <summary>
        /// 亚运贡献公益林能量
        /// </summary>
        [XmlElement("energy")]
        public long Energy { get; set; }

        /// <summary>
        /// 公益林参与人数
        /// </summary>
        [XmlElement("total_uv")]
        public long TotalUv { get; set; }
    }
}
