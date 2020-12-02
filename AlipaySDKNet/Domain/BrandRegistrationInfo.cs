using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BrandRegistrationInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BrandRegistrationInfo : AopObject
    {
        /// <summary>
        /// 商标有效期(结束日期)
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 商标注册证书信息(当前只支持图片类型，请调用alipay.open.mini.miniapp.brand.upload接口上传图片,可以上传多个商标注册证书信息)
        /// </summary>
        [XmlArray("reg_materials")]
        [XmlArrayItem("string")]
        public List<string> RegMaterials { get; set; }

        /// <summary>
        /// 商标注册号
        /// </summary>
        [XmlElement("reg_number")]
        public string RegNumber { get; set; }

        /// <summary>
        /// 商标注册人
        /// </summary>
        [XmlElement("registrant")]
        public string Registrant { get; set; }

        /// <summary>
        /// 商标有效期(开始日期)
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }
    }
}
