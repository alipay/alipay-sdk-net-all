using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandEcoNfcCheckResponse.
    /// </summary>
    public class AntMerchantExpandEcoNfcCheckResponse : AopResponse
    {
        /// <summary>
        /// ture 可以绑定  false 不可以绑定
        /// </summary>
        [XmlElement("allow_bind")]
        public bool AllowBind { get; set; }

        /// <summary>
        /// RISK_INTERCEPT 风控拦截不可绑定 NO_SIGN 未签约请先引导签约 TIME_OUT 超时可重试 UNKNOW 其它未知原因
        /// </summary>
        [XmlElement("forbid_bind_reason")]
        public string ForbidBindReason { get; set; }

        /// <summary>
        /// 线圈对应的物料ID
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 物料类型标识，财神空码: cai_shen_empty_code，不需要传qrcodeTokens
        /// </summary>
        [XmlElement("material_type")]
        public string MaterialType { get; set; }
    }
}
