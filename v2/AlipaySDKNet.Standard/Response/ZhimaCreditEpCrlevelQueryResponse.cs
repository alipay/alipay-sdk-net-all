using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpCrlevelQueryResponse.
    /// </summary>
    public class ZhimaCreditEpCrlevelQueryResponse : AopResponse
    {
        /// <summary>
        /// CR等级，1-12
        /// </summary>
        [XmlElement("cr_rank")]
        public string CrRank { get; set; }

        /// <summary>
        /// CR等级描述，枚举值【好、较好、中等、中等偏下、较差、差】
        /// </summary>
        [XmlElement("cr_rank_title")]
        public string CrRankTitle { get; set; }

        /// <summary>
        /// 企业是否有CR等级，true:有;false:没有。 false时cr_rank和cr_rank_title为null
        /// </summary>
        [XmlElement("has_cr_rank")]
        public bool HasCrRank { get; set; }
    }
}
