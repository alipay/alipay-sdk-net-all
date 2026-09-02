using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiMemberGradeQueryResponse.
    /// </summary>
    public class AlipayPcreditHuabeiMemberGradeQueryResponse : AopResponse
    {
        /// <summary>
        /// 花呗等级  V1 V2 V3 V4
        /// </summary>
        [XmlElement("grade")]
        public string Grade { get; set; }
    }
}
