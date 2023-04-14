using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppServicePromotemplateQueryResponse.
    /// </summary>
    public class AlipayOpenAppServicePromotemplateQueryResponse : AopResponse
    {
        /// <summary>
        /// 展台准入类目列表
        /// </summary>
        [XmlArray("promo_access_catalog_vos")]
        [XmlArrayItem("promo_access_base_catalog_v_o")]
        public List<PromoAccessBaseCatalogVO> PromoAccessCatalogVos { get; set; }

        /// <summary>
        /// 展台的描述信息
        /// </summary>
        [XmlElement("promo_booth_desc")]
        public string PromoBoothDesc { get; set; }

        /// <summary>
        /// https://opendocs.alipay.com/mini/operation/as2i2u#FAQ
        /// </summary>
        [XmlElement("promo_booth_desc_url")]
        public string PromoBoothDescUrl { get; set; }

        /// <summary>
        /// 展台允许的实体数量类型； SINGLE_SERVICE("SINGLE_SERVICE", "单个服务"), MULTI_SERVICE_OF_ONE_CAT("MULTI_SERVICE_OF_ONE_CAT", "同类目下多个服务")
        /// </summary>
        [XmlElement("promo_booth_entity_num_type")]
        public string PromoBoothEntityNumType { get; set; }

        /// <summary>
        /// 展台允许的实体数量类型。枚举值如下： STD_SERVICE("STD_SERVICE", "标准化服务"), MINI_APP("MINI_APP", "小程序"),
        /// </summary>
        [XmlElement("promo_booth_entity_type")]
        public string PromoBoothEntityType { get; set; }

        /// <summary>
        /// 展台ID
        /// </summary>
        [XmlElement("promo_booth_id")]
        public string PromoBoothId { get; set; }

        /// <summary>
        /// 展台名称
        /// </summary>
        [XmlElement("promo_booth_name")]
        public string PromoBoothName { get; set; }

        /// <summary>
        /// 内容schema
        /// </summary>
        [XmlArray("promo_content_api_schema_vos")]
        [XmlArrayItem("promo_content_api_schema_v_o")]
        public List<PromoContentApiSchemaVO> PromoContentApiSchemaVos { get; set; }
    }
}
