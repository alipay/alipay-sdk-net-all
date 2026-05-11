using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityRiskVerifyidentityVoiceprintRecommendResponse.
    /// </summary>
    public class AlipaySecurityRiskVerifyidentityVoiceprintRecommendResponse : AopResponse
    {
        /// <summary>
        /// is_success=FALSE时返回
        /// </summary>
        [XmlElement("err_code")]
        public string ErrCode { get; set; }

        /// <summary>
        /// 错误信息，is_success=FALSE时返回
        /// </summary>
        [XmlElement("err_msg")]
        public string ErrMsg { get; set; }

        /// <summary>
        /// 只有TRUE,FALSE。接口调用是否成功，为FALSE时表示调用失败，会同时返回err_code和err_msg
        /// </summary>
        [XmlElement("is_success")]
        public string IsSuccess { get; set; }

        /// <summary>
        /// 推荐详情页URL，recommend_type=render且is_success=TRUE时返回
        /// </summary>
        [XmlElement("open_url")]
        public string OpenUrl { get; set; }

        /// <summary>
        /// 是否推荐开通声纹，recommend_type=consult时返回。
        /// </summary>
        [XmlElement("recommendable")]
        public string Recommendable { get; set; }
    }
}
