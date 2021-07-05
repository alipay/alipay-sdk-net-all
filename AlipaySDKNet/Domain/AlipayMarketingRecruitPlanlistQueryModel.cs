using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingRecruitPlanlistQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingRecruitPlanlistQueryModel : AopObject
    {
        /// <summary>
        /// 第几页，默认1（需要在1和999之间）
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页记录条数，默认20，需要在1和100之间
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
