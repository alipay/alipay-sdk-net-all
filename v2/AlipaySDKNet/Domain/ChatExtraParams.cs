using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ChatExtraParams Data Structure.
    /// </summary>
    [Serializable]
    public class ChatExtraParams : AopObject
    {
        /// <summary>
        /// 用于描述客户端信息，业务自定义信息。对应“支小宝投放”生码的“业务自定义信息”
        /// </summary>
        [XmlElement("agent_ext_info")]
        public string AgentExtInfo { get; set; }

        /// <summary>
        /// 用于描述用户信息，证件号。
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 用于描述用户信息，证件类型。
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 城市编码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 城市名称
        /// </summary>
        [XmlElement("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 用于描述客户端信息，请求入口。对应“支小宝投放”生码的"场景ID或agentID_渠道类型"。
        /// </summary>
        [XmlElement("entrance")]
        public string Entrance { get; set; }

        /// <summary>
        /// 用于描述客户端信息，请求来源。
        /// </summary>
        [XmlElement("from_source")]
        public string FromSource { get; set; }

        /// <summary>
        /// 用于描述空间信息，经纬度的纬度。
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 用于描述空间信息，经纬度的经度。
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 用于描述用户信息，手机号。
        /// </summary>
        [XmlElement("phone_no")]
        public string PhoneNo { get; set; }
    }
}
