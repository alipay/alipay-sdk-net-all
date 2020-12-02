using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ApplySubAccountAndBindResultDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ApplySubAccountAndBindResultDTO : AopObject
    {
        /// <summary>
        /// 受理单号
        /// </summary>
        [XmlElement("apply_no")]
        public string ApplyNo { get; set; }

        /// <summary>
        /// 受理单状态，申请成功后受理单状态为INIT
        /// </summary>
        [XmlElement("apply_status")]
        public string ApplyStatus { get; set; }
    }
}
