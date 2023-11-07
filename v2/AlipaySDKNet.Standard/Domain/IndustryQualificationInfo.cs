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
        /// 商户行业资质类型，具体选值参见，进件MCC与资质要求 <a href="https://gw.alipayobjects.com/os/bmw-prod/7aa3a36b-2bc2-4d57-815f-08edd55ef67e.xlsx">202212.xlsx</a>中特殊资质栏
        /// </summary>
        [XmlElement("industry_qualification_type")]
        public string IndustryQualificationType { get; set; }
    }
}
