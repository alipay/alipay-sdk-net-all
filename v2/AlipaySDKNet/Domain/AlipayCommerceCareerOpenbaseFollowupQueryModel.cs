using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceCareerOpenbaseFollowupQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceCareerOpenbaseFollowupQueryModel : AopObject
    {
        /// <summary>
        /// 客户业务单号，任务定位键。查询仅以该字段定位任务，无其他定位入参。
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
