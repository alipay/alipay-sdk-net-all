using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceRentOrderSignResponse.
    /// </summary>
    public class AlipayCommerceRentOrderSignResponse : AopResponse
    {
        /// <summary>
        /// 签约方式，使用插件拉起受理台进行签约，具体使用方法请参考 <a href="https://opendocs.alipay.com/solution/0h845z?pathHash=d2c7ca4f#%E7%AD%BE%E7%BA%A6%E8%AE%A2%E5%8D%95" target="_blank">接入指南-签约订单</a>
        /// </summary>
        [XmlElement("sign_launch_method")]
        public string SignLaunchMethod { get; set; }

        /// <summary>
        /// 授权签名字符串
        /// </summary>
        [XmlElement("sign_str")]
        public string SignStr { get; set; }
    }
}
