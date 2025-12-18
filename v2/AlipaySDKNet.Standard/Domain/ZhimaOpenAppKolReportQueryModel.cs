using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaOpenAppKolReportQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaOpenAppKolReportQueryModel : AopObject
    {
        /// <summary>
        /// 领取口令词对应达人机构名
        /// </summary>
        [XmlElement("corp_name")]
        public string CorpName { get; set; }

        /// <summary>
        /// 查询转化报表截止日期（不含当日）
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 查询口令词
        /// </summary>
        [XmlElement("search_word")]
        public string SearchWord { get; set; }

        /// <summary>
        /// 查询转化报表开始日期
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }
    }
}
