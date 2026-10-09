using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainFinanceTvpAccountApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainFinanceTvpAccountApplyModel : AopObject
    {
        /// <summary>
        /// 子户开立申请主体
        /// </summary>
        [XmlElement("apply_entity")]
        public TrustEntityInfo ApplyEntity { get; set; }

        /// <summary>
        /// 可信价值中心产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 外部请求号，商户唯一
        /// </summary>
        [XmlElement("request_no")]
        public string RequestNo { get; set; }

        /// <summary>
        /// 子户开立场景方。 可信账单产品，传入服务企业信息。
        /// </summary>
        [XmlElement("scene_entity")]
        public TrustEntityInfo SceneEntity { get; set; }
    }
}
