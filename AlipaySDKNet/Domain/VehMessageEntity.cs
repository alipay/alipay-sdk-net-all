using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VehMessageEntity Data Structure.
    /// </summary>
    [Serializable]
    public class VehMessageEntity : AopObject
    {
        /// <summary>
        /// 证件号码.(certificate_type/certificate_number/certificate_username) 或者uid必须有一个不为空。两个都不为空则以uid为准. 该字段为敏感字段，须做md5处理后传输。示例中值的明文为310101198011110010.
        /// </summary>
        [XmlElement("certificate_number")]
        public string CertificateNumber { get; set; }

        /// <summary>
        /// 证件类型, 01表示身份证.(certificate_type/certificate_number/certificate_username) 或者uid必须有一个不为空。两个都不为空则以uid为准.
        /// </summary>
        [XmlElement("certificate_type")]
        public string CertificateType { get; set; }

        /// <summary>
        /// 证件用户名字.(certificate_type/certificate_number/certificate_username) 或者uid必须有一个不为空。两个都不为空则以uid为准.
        /// </summary>
        [XmlElement("certificate_username")]
        public string CertificateUsername { get; set; }

        /// <summary>
        /// 消息参数信息，json格式字符串. 该字段与msg_type对应，不同的sc需要传不同的参数信息，详情参考接口补充说明.
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 消息提示红点标记
        /// </summary>
        [XmlElement("mark")]
        public string Mark { get; set; }

        /// <summary>
        /// 消息模板id
        /// </summary>
        [XmlElement("msg_template_id")]
        public string MsgTemplateId { get; set; }

        /// <summary>
        /// identity字段：值为不大于64位的保证唯一的字符串；该字段用于保证消息唯一性，防止消息重复推送，相当于业务流水号，由接入方自行生成
        /// </summary>
        [XmlElement("out_msg_id")]
        public string OutMsgId { get; set; }

        /// <summary>
        /// 消息跳转url。
        /// </summary>
        [XmlElement("target_url")]
        public string TargetUrl { get; set; }

        /// <summary>
        /// (certificate_type/certificate_number/用户名字) 或者uid必须有一个不为空。两个都不为空则以uid为准
        /// </summary>
        [XmlElement("uid")]
        public string Uid { get; set; }
    }
}
