using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataMdaAsiangamesofflineQueryResponse.
    /// </summary>
    public class AlipayDataMdaAsiangamesofflineQueryResponse : AopResponse
    {
        /// <summary>
        /// 亚运路线完成人数
        /// </summary>
        [XmlElement("complete_route_uv")]
        public long CompleteRouteUv { get; set; }

        /// <summary>
        /// 步数绕地球圈数
        /// </summary>
        [XmlElement("ring_cnt")]
        public long RingCnt { get; set; }

        /// <summary>
        /// 累计步数
        /// </summary>
        [XmlElement("steps_cnt")]
        public long StepsCnt { get; set; }

        /// <summary>
        /// TOP5亚运路线
        /// </summary>
        [XmlElement("top_5_route")]
        public string Top5Route { get; set; }

        /// <summary>
        /// 亚运路线参与人数
        /// </summary>
        [XmlElement("total_uv")]
        public long TotalUv { get; set; }
    }
}
