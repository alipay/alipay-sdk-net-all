using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportEtcTollfeeQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportEtcTollfeeQueryResponse : AopResponse
    {
        /// <summary>
        /// 出站城市
        /// </summary>
        [XmlElement("end_city")]
        public string EndCity { get; set; }

        /// <summary>
        /// 出口收费站名称
        /// </summary>
        [XmlElement("end_station")]
        public string EndStation { get; set; }

        /// <summary>
        /// 进站城市
        /// </summary>
        [XmlElement("start_city")]
        public string StartCity { get; set; }

        /// <summary>
        /// 起点收费站名称
        /// </summary>
        [XmlElement("start_station")]
        public string StartStation { get; set; }

        /// <summary>
        /// 通行费统计
        /// </summary>
        [XmlElement("toll_stats")]
        public EtcTollFeeTollStatsDTO TollStats { get; set; }
    }
}
