using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLogisticsTokenWaybillQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLogisticsTokenWaybillQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝跳转商户小程序携带的token，商户通过token回查支付宝获取token关联的运单信息
        /// </summary>
        [XmlElement("info_token")]
        public string InfoToken { get; set; }

        /// <summary>
        /// token场景 NFC_PICK_PKG碰一下取件
        /// </summary>
        [XmlElement("token_scene")]
        public string TokenScene { get; set; }
    }
}
