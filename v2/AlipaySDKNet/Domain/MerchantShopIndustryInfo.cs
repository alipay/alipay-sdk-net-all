using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MerchantShopIndustryInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantShopIndustryInfo : AopObject
    {
        /// <summary>
        /// 行业信息CODE
        /// </summary>
        [XmlElement("info_code")]
        public string InfoCode { get; set; }

        /// <summary>
        /// 行业信息值，具体值根据info_code决定。 当info_code=SHOP_MEDICAL_LOGO/SHOP_MEDICAL_IN_PIC这类文件信息时， 需要传入ant.merchant.expand.indirect.image.upload接口上传的文件key；当info_code= SHOP_MEDICAL_LEVEL_TAG时，需要<a href="https://mdn.alipayobjects.com/mrcheshop/afts/file/ZuDmQKgBifgAAAAAAAAAAAAADiWmAQBr?af_filename=医院类型.xlsx">医院类型</a>中CODE；其他场景传入自定义文本即可。
        /// </summary>
        [XmlArray("info_value")]
        [XmlArrayItem("string")]
        public List<string> InfoValue { get; set; }
    }
}
