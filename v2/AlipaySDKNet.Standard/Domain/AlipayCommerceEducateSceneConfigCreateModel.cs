using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateSceneConfigCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateSceneConfigCreateModel : AopObject
    {
        /// <summary>
        /// 经营场景，若传签约收款商户pid，则经营场景必传
        /// </summary>
        [XmlElement("business_scene")]
        public string BusinessScene { get; set; }

        /// <summary>
        /// 签约收款商户的pid
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 学校内标
        /// </summary>
        [XmlElement("school_id")]
        public string SchoolId { get; set; }

        /// <summary>
        /// 学校外标（内外标不可同时为空，都传入时以内标为准）
        /// </summary>
        [XmlElement("school_std_code")]
        public string SchoolStdCode { get; set; }

        /// <summary>
        /// 签约小程序appid
        /// </summary>
        [XmlElement("sign_app_id")]
        public string SignAppId { get; set; }
    }
}
