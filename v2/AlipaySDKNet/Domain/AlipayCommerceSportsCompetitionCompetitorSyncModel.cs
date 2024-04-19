using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceSportsCompetitionCompetitorSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceSportsCompetitionCompetitorSyncModel : AopObject
    {
        /// <summary>
        /// 中文名称
        /// </summary>
        [XmlElement("cn_name")]
        public string CnName { get; set; }

        /// <summary>
        /// 参赛者code
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 赛事编号
        /// </summary>
        [XmlElement("competition_code")]
        public string CompetitionCode { get; set; }

        /// <summary>
        /// 版本
        /// </summary>
        [XmlElement("data_version")]
        public long DataVersion { get; set; }

        /// <summary>
        /// 英文名称
        /// </summary>
        [XmlElement("en_name")]
        public string EnName { get; set; }

        /// <summary>
        /// 图片链接
        /// </summary>
        [XmlElement("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
