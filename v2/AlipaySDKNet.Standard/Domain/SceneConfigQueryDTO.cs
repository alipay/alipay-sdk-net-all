using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SceneConfigQueryDTO Data Structure.
    /// </summary>
    [Serializable]
    public class SceneConfigQueryDTO : AopObject
    {
        /// <summary>
        /// 经营范围
        /// </summary>
        [XmlArray("business_scene")]
        [XmlArrayItem("string")]
        public List<string> BusinessScene { get; set; }

        /// <summary>
        /// 人脸库id
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 服务商中文名称
        /// </summary>
        [XmlElement("isv_name")]
        public string IsvName { get; set; }

        /// <summary>
        /// 收款商户pid
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 学校内标
        /// </summary>
        [XmlElement("school_id")]
        public string SchoolId { get; set; }

        /// <summary>
        /// 学校名称
        /// </summary>
        [XmlElement("school_name")]
        public string SchoolName { get; set; }

        /// <summary>
        /// 学校外标
        /// </summary>
        [XmlElement("school_std_code")]
        public string SchoolStdCode { get; set; }

        /// <summary>
        /// 签约小程序appId
        /// </summary>
        [XmlElement("sign_app_id")]
        public string SignAppId { get; set; }

        /// <summary>
        /// 状态，审核中AUDITING/已生效VALID
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
