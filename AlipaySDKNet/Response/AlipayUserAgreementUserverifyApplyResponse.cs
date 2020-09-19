using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserAgreementUserverifyApplyResponse.
    /// </summary>
    public class AlipayUserAgreementUserverifyApplyResponse : AopResponse
    {
        /// <summary>
        /// 用户验证申请token，其格式和内容，由支付宝定义。在鉴权确认的过程中，商户可根据申请操作成功时返回的申请token，获取后续的买家结果
        /// </summary>
        [XmlElement("apply_token")]
        public string ApplyToken { get; set; }
    }
}
