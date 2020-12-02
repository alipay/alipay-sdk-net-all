using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AuthorizeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AuthorizeInfo : AopObject
    {
        /// <summary>
        /// 授权方身份证明(当前只支持图片类型，请调用alipay.open.mini.miniapp.brand.upload接口上传图片,可以上传多个授权方身份证明)
        /// </summary>
        [XmlArray("auth_ids")]
        [XmlArrayItem("string")]
        public List<string> AuthIds { get; set; }

        /// <summary>
        /// 授权有效资质(当前只支持图片类型，请调用alipay.open.mini.miniapp.brand.upload接口上传图片，可以上传多个授权有效资质)
        /// </summary>
        [XmlArray("auth_materials")]
        [XmlArrayItem("string")]
        public List<string> AuthMaterials { get; set; }

        /// <summary>
        /// 被授权人名称
        /// </summary>
        [XmlElement("auth_name")]
        public string AuthName { get; set; }

        /// <summary>
        /// 授权有效期(结束日期)
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 授权有效期(开始日期)
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }
    }
}
