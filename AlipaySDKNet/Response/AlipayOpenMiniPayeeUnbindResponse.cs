using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniPayeeUnbindResponse.
    /// </summary>
    public class AlipayOpenMiniPayeeUnbindResponse : AopResponse
    {
        /// <summary>
        /// 解绑结果，true解绑成功，false解绑失败
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
