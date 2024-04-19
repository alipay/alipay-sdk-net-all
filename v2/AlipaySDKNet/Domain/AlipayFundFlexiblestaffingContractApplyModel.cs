using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundFlexiblestaffingContractApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundFlexiblestaffingContractApplyModel : AopObject
    {
        /// <summary>
        /// 签约跳转类型，有限枚举， SHORT_URL：短链接
        /// </summary>
        [XmlElement("apply_link_type")]
        public string ApplyLinkType { get; set; }

        /// <summary>
        /// 业务场景码
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 签约跳转渠道，有限枚举，tinyapp：小程序
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 合同模版的填充参数，是实际合同模板设置提供的
        /// </summary>
        [XmlElement("contract_template_fields")]
        public string ContractTemplateFields { get; set; }

        /// <summary>
        /// 超时时间，建议在距离接口请求时间2小时到3天之间。
        /// </summary>
        [XmlElement("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 商户端唯一订单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 业务产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 申请签约的主体
        /// </summary>
        [XmlElement("sign_principal")]
        public SignPrincipalDTO SignPrincipal { get; set; }

        /// <summary>
        /// 签约方案ID
        /// </summary>
        [XmlElement("solution_code")]
        public string SolutionCode { get; set; }
    }
}
