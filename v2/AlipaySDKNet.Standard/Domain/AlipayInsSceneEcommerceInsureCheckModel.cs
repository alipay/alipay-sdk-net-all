using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneEcommerceInsureCheckModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneEcommerceInsureCheckModel : AopObject
    {
        /// <summary>
        /// 批量的【商品、卖家和卖家信息】
        /// </summary>
        [XmlArray("insure_admit_dto_list")]
        [XmlArrayItem("insure_admit_d_t_o")]
        public List<InsureAdmitDTO> InsureAdmitDtoList { get; set; }

        /// <summary>
        /// 合作商标识
        /// </summary>
        [XmlElement("partner_org_id")]
        public string PartnerOrgId { get; set; }

        /// <summary>
        /// 产品编码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 场景码
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 客户端渠道
        /// </summary>
        [XmlElement("user_client")]
        public string UserClient { get; set; }
    }
}
