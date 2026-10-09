using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineProviderCollaborateAuthCreateResponse.
    /// </summary>
    public class AlipayOfflineProviderCollaborateAuthCreateResponse : AopResponse
    {
        /// <summary>
        /// 申请授权的二维码链接，需要将该链接生成二维码引导被授权人（即签约卖进方案的用户）进行扫码，扫码后将会引导向smid的法人或联系人申请设备绑定授权。
        /// </summary>
        [XmlElement("apply_auth_url")]
        public string ApplyAuthUrl { get; set; }

        /// <summary>
        /// 授权申请单ID，可以使用该ID查询授权申请单状态
        /// </summary>
        [XmlElement("auth_order_id")]
        public string AuthOrderId { get; set; }
    }
}
