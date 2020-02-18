using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceIotWifiResultQueryResponse.
    /// </summary>
    public class AlipayCommerceIotWifiResultQueryResponse : AopResponse
    {
        /// <summary>
        /// 配网状态：    //-1.表示设备还没上报配网结果  //1.wifi连接成功  //2. 找不到该wifi  //3. wifi密码错误
        /// </summary>
        [XmlElement("result_type")]
        public long ResultType { get; set; }

        /// <summary>
        /// wifi名称
        /// </summary>
        [XmlElement("ssid")]
        public string Ssid { get; set; }
    }
}
