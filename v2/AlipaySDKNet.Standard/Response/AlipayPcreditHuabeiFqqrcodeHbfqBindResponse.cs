using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiFqqrcodeHbfqBindResponse.
    /// </summary>
    public class AlipayPcreditHuabeiFqqrcodeHbfqBindResponse : AopResponse
    {
        /// <summary>
        /// 本次绑码操作是否成功,成功为true,失败为false.
        /// </summary>
        [XmlElement("bind")]
        public bool Bind { get; set; }
    }
}
