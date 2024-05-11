using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IndustryQualificationInfo Data Structure.
    /// </summary>
    [Serializable]
    public class IndustryQualificationInfo : AopObject
    {
        /// <summary>
        /// 商户行业资质图片。其值为通过ant.merchant.expand.indirect.image.upload上传图片得到的image_id
        /// </summary>
        [XmlElement("industry_qualification_image")]
        public string IndustryQualificationImage { get; set; }

        /// <summary>
        /// <a href="https://gw.alipayobjects.com/os/bmw-prod/7aa3a36b-2bc2-4d57-815f-08edd55ef67e.xlsx">商户行业资质类型，具体选值参见文档</a>
        /// </summary>
        [XmlElement("industry_qualification_type")]
        public string IndustryQualificationType { get; set; }
    }
}
