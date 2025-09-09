using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalAnttechAmpAigcQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalAnttechAmpAigcQueryModel : AopObject
    {
        /// <summary>
        /// 参数数据
        /// </summary>
        [XmlElement("param_data")]
        public string ParamData { get; set; }

        /// <summary>
        /// 业务请求id
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 企业社会信用代码
        /// </summary>
        [XmlElement("social_code")]
        public string SocialCode { get; set; }
    }
}
