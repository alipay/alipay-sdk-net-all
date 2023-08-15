using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataMdaTorchreplaycenterreaQueryResponse.
    /// </summary>
    public class AlipayDataMdaTorchreplaycenterreaQueryResponse : AopResponse
    {
        /// <summary>
        /// 亚运在中国
        /// </summary>
        [XmlElement("internal_china_replay_cnt")]
        public long InternalChinaReplayCnt { get; set; }

        /// <summary>
        /// 南亚&中亚累计传递人次
        /// </summary>
        [XmlElement("south_and_central_asia_torch_replay_cnt")]
        public long SouthAndCentralAsiaTorchReplayCnt { get; set; }

        /// <summary>
        /// 西亚&东南亚&东亚累计传递人次
        /// </summary>
        [XmlElement("west_and_southeast_asia_torch_replay_cnt")]
        public long WestAndSoutheastAsiaTorchReplayCnt { get; set; }
    }
}
