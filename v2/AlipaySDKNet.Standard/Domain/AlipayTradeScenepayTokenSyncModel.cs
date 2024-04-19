using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeScenepayTokenSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeScenepayTokenSyncModel : AopObject
    {
        /// <summary>
        /// 签约协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 场景码
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 场景支付凭证
        /// </summary>
        [XmlElement("scene_pay_token")]
        public ScenePayToken ScenePayToken { get; set; }

        /// <summary>
        /// 子场景码
        /// </summary>
        [XmlElement("sub_biz_scene")]
        public string SubBizScene { get; set; }

        /// <summary>
        /// 一码付凭证同步扩展信息
        /// </summary>
        [XmlElement("union_code_extend_params")]
        public UnionCodeExtendParam UnionCodeExtendParams { get; set; }
    }
}
