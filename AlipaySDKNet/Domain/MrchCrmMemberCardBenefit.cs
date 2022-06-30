using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MrchCrmMemberCardBenefit Data Structure.
    /// </summary>
    [Serializable]
    public class MrchCrmMemberCardBenefit : AopObject
    {
        /// <summary>
        /// 商家会员权益描述
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 权益icon图片链接，通过接口（alipay.offline.material.image.upload）上传图片
        /// </summary>
        [XmlElement("logo_url")]
        public string LogoUrl { get; set; }

        /// <summary>
        /// 商家会员权益
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
