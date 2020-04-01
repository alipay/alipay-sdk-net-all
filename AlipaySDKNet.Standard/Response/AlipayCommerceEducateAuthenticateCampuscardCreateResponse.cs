using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateAuthenticateCampuscardCreateResponse.
    /// </summary>
    public class AlipayCommerceEducateAuthenticateCampuscardCreateResponse : AopResponse
    {
        /// <summary>
        /// 如果学生学籍插入成功，则返回SUCCESS ， 失败返回FAIL
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
