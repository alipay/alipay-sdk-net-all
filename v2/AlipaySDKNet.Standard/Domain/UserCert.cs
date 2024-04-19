using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UserCert Data Structure.
    /// </summary>
    [Serializable]
    public class UserCert : AopObject
    {
        /// <summary>
        /// 申请证书的时间，不是种树时间
        /// </summary>
        [XmlElement("apply_time")]
        public string ApplyTime { get; set; }

        /// <summary>
        /// 用户环保证书id
        /// </summary>
        [XmlElement("certificate_id")]
        public string CertificateId { get; set; }

        /// <summary>
        /// 扩展信息，格式为JSON字符串，具体k-v需要跟接口提供方确认后使用
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 树已经种下时所在的林区id
        /// </summary>
        [XmlElement("forest_id")]
        public string ForestId { get; set; }

        /// <summary>
        /// 公益机构名称
        /// </summary>
        [XmlElement("ngo_name")]
        public string NgoName { get; set; }

        /// <summary>
        /// 树种是否种下
        /// </summary>
        [XmlElement("planted")]
        public bool Planted { get; set; }

        /// <summary>
        /// 树种或保护地所在区域
        /// </summary>
        [XmlElement("region")]
        public string Region { get; set; }

        /// <summary>
        /// 树种或者保护地名称
        /// </summary>
        [XmlElement("tree_name")]
        public string TreeName { get; set; }

        /// <summary>
        /// 证书类型：树种-"TREE"/保护地-"RESERVE"
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
