using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BsEnrollParticipantResult Data Structure.
    /// </summary>
    [Serializable]
    public class BsEnrollParticipantResult : AopObject
    {
        /// <summary>
        /// 报名是否成功。如果失败会有reason和code返回
        /// </summary>
        [XmlElement("enroll_result")]
        public bool EnrollResult { get; set; }

        /// <summary>
        /// 报名结果详细信息
        /// </summary>
        [XmlElement("enroll_result_detail")]
        public BsEnrollParticipantResultDetail EnrollResultDetail { get; set; }

        /// <summary>
        /// 报名失败的错误码，仅限报名失败场景透出。
        /// </summary>
        [XmlElement("fail_code")]
        public string FailCode { get; set; }

        /// <summary>
        /// 报名操作返回的失败原因，仅限报名失败场景透出
        /// </summary>
        [XmlElement("fail_reason")]
        public string FailReason { get; set; }

        /// <summary>
        /// 类型对应值，传入报名对象的返回值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
