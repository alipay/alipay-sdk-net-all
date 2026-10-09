using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntfortuneStockDarwinQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntfortuneStockDarwinQueryModel : AopObject
    {
        /// <summary>
        /// 签约协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// icrowd人群id
        /// </summary>
        [XmlElement("crowd_id")]
        public string CrowdId { get; set; }

        /// <summary>
        /// 实验场景
        /// </summary>
        [XmlElement("scenario")]
        public string Scenario { get; set; }

        /// <summary>
        /// 调用trace
        /// </summary>
        [XmlElement("trace")]
        public string Trace { get; set; }
    }
}
