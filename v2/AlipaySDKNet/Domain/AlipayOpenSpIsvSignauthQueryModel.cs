using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSpIsvSignauthQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSpIsvSignauthQueryModel : AopObject
    {
        /// <summary>
        /// 签约授权一体化订单ID 可通过alipay.open.sp.isv.signauth.create 接口获取
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
