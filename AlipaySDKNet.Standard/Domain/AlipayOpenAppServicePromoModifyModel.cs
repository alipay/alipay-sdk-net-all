using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppServicePromoModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppServicePromoModifyModel : AopObject
    {
        /// <summary>
        /// 服务场景素材具体内容列表
        /// </summary>
        [XmlArray("promo_contents")]
        [XmlArrayItem("promo_content_biz_v_o")]
        public List<PromoContentBizVO> PromoContents { get; set; }

        /// <summary>
        /// 服务场景素材记录ID
        /// </summary>
        [XmlElement("promo_record_id")]
        public string PromoRecordId { get; set; }
    }
}
