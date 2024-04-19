using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecruitFailureInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RecruitFailureInfo : AopObject
    {
        /// <summary>
        /// 创建活动报名失败原因。调用创建活动报名接口经业务校验不通过的提示信息。
        /// </summary>
        [XmlElement("enroll_failure_reason")]
        public string EnrollFailureReason { get; set; }
    }
}
