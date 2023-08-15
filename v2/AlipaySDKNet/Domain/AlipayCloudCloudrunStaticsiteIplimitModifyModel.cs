using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudrunStaticsiteIplimitModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudrunStaticsiteIplimitModifyModel : AopObject
    {
        /// <summary>
        /// 内部使用，uiam角色扮演token
        /// </summary>
        [XmlElement("assume_token")]
        public string AssumeToken { get; set; }

        /// <summary>
        /// 是否开启黑白名单
        /// </summary>
        [XmlElement("enable")]
        public bool Enable { get; set; }

        /// <summary>
        /// 环境ID，唯一，开通小程序云系统会生成环境ID，请从开通页面获取
        /// </summary>
        [XmlElement("env")]
        public string Env { get; set; }

        /// <summary>
        /// IP列表。 输入IP段（不可重复，例如：192.168.0.0/24）或IP地址（例如192.168.0.1）。支持IPv6地址、IPv4地址。 IPv6地址不支持::缩写格式，例如：不支持FC00:0AA3::0023:0003:0300:300A:1234。支持输入IP段，例如：FC00:0AA3:0000:0000:0000:0000:0000:0000/48。
        /// </summary>
        [XmlArray("ip_list")]
        [XmlArrayItem("string")]
        public List<string> IpList { get; set; }

        /// <summary>
        /// 限制类型
        /// </summary>
        [XmlElement("limit_type")]
        public string LimitType { get; set; }
    }
}
