using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppServicePromoApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppServicePromoApplyModel : AopObject
    {
        /// <summary>
        /// 展台ID
        /// </summary>
        [XmlElement("promo_booth_id")]
        public string PromoBoothId { get; set; }

        /// <summary>
        /// 具体内容列表
        /// </summary>
        [XmlArray("promo_contents")]
        [XmlArrayItem("promo_content_biz_v_o")]
        public List<PromoContentBizVO> PromoContents { get; set; }

        /// <summary>
        /// 实体的编码列表
        /// </summary>
        [XmlElement("promo_entity_codes")]
        public string PromoEntityCodes { get; set; }

        /// <summary>
        /// 实体类型。枚举值如下： MINI_APP("MINI_APP", "小程序"), STD_SERVICE("STD_SERVICE", "标准化服务"), SERVICE_BACK_CATALOG("SERVICE_BACK_CATALOG", "服务类目")
        /// </summary>
        [XmlElement("promo_entity_type")]
        public string PromoEntityType { get; set; }
    }
}
