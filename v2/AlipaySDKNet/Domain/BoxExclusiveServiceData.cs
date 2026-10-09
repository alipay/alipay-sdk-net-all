using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BoxExclusiveServiceData Data Structure.
    /// </summary>
    [Serializable]
    public class BoxExclusiveServiceData : AopObject
    {
        /// <summary>
        /// 2020012321000607972103
        /// </summary>
        [XmlElement("serv_code")]
        public string ServCode { get; set; }

        /// <summary>
        /// 服务描述
        /// </summary>
        [XmlElement("serv_desc")]
        public string ServDesc { get; set; }

        /// <summary>
        /// 服务id
        /// </summary>
        [XmlElement("serv_id")]
        public string ServId { get; set; }

        /// <summary>
        /// 服务链接
        /// </summary>
        [XmlElement("serv_link")]
        public string ServLink { get; set; }

        /// <summary>
        /// 服务logo
        /// </summary>
        [XmlElement("serv_logo")]
        public string ServLogo { get; set; }

        /// <summary>
        /// 服务名称
        /// </summary>
        [XmlElement("serv_name")]
        public string ServName { get; set; }
    }
}
