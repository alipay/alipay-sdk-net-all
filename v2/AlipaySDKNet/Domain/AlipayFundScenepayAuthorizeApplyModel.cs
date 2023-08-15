using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundScenepayAuthorizeApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundScenepayAuthorizeApplyModel : AopObject
    {
        /// <summary>
        /// 商户授权
        /// </summary>
        [XmlElement("authorization_type")]
        public string AuthorizationType { get; set; }

        /// <summary>
        /// 场景码
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 业务/被授权方主体
        /// </summary>
        [XmlElement("business_principal_info")]
        public ScenePayParticipantInfoDTO BusinessPrincipalInfo { get; set; }

        /// <summary>
        /// 代扣信息
        /// </summary>
        [XmlElement("general_withhold_info")]
        public GeneralWithholdInfoDTO GeneralWithholdInfo { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 授权主体
        /// </summary>
        [XmlElement("principal_info")]
        public ScenePayParticipantInfoDTO PrincipalInfo { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 子场景码
        /// </summary>
        [XmlElement("sub_biz_scene")]
        public string SubBizScene { get; set; }
    }
}
