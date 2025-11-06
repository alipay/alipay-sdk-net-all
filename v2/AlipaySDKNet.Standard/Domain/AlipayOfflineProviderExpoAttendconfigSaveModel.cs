using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineProviderExpoAttendconfigSaveModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderExpoAttendconfigSaveModel : AopObject
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [XmlElement("activity_code")]
        public string ActivityCode { get; set; }

        /// <summary>
        /// 线圈物料的编号
        /// </summary>
        [XmlElement("coil_no")]
        public string CoilNo { get; set; }

        /// <summary>
        /// 可用的logo URL
        /// </summary>
        [XmlElement("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 解决方案code
        /// </summary>
        [XmlElement("solution_code")]
        public string SolutionCode { get; set; }
    }
}
