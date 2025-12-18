using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UserCertifyInfo Data Structure.
    /// </summary>
    [Serializable]
    public class UserCertifyInfo : AopObject
    {
        /// <summary>
        /// 核身数据
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }

        /// <summary>
        /// 核身任务ID
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 核身结果，true通过false不通过
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }

        /// <summary>
        /// 核身时间，YYYY-MM-DD HH:mm:ss
        /// </summary>
        [XmlElement("time")]
        public string Time { get; set; }

        /// <summary>
        /// 认证类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
