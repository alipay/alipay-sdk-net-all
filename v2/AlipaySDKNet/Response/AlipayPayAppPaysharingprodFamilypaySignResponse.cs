using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPayAppPaysharingprodFamilypaySignResponse.
    /// </summary>
    public class AlipayPayAppPaysharingprodFamilypaySignResponse : AopResponse
    {
        /// <summary>
        /// 签约授权单号，业务方可通过这个单号进行查询
        /// </summary>
        [XmlElement("apply_no")]
        public string ApplyNo { get; set; }

        /// <summary>
        /// 授权地址，业务方重定向当前地址跳转支付宝内完成亲情卡签约
        /// </summary>
        [XmlElement("auth_url")]
        public string AuthUrl { get; set; }
    }
}
