using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsClaimReporterDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InsClaimReporterDTO : AopObject
    {
        /// <summary>
        /// 报案人身份证号
        /// </summary>
        [XmlElement("reporter_id_card_no")]
        public string ReporterIdCardNo { get; set; }

        /// <summary>
        /// 报案人姓名
        /// </summary>
        [XmlElement("reporter_name")]
        public string ReporterName { get; set; }

        /// <summary>
        /// 报案人user_id
        /// </summary>
        [XmlElement("reporter_uid")]
        public string ReporterUid { get; set; }
    }
}
