using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AssistantLicenseInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AssistantLicenseInfo : AopObject
    {
        /// <summary>
        /// 许可证开始生效时间，为一个时间字段，在这个时间点后（包含当前时间点）可使用
        /// </summary>
        [XmlElement("begin_time")]
        public string BeginTime { get; set; }

        /// <summary>
        /// 许可证失效时间，表示在这个时间(不包括当前时间)之后，当前凭证不可使用，
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 许可证信息，用户使用这个许可证绑定后可使用相应的权益
        /// </summary>
        [XmlElement("license")]
        public string License { get; set; }
    }
}
