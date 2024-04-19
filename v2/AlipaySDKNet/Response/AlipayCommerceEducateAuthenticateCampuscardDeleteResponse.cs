using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateAuthenticateCampuscardDeleteResponse.
    /// </summary>
    public class AlipayCommerceEducateAuthenticateCampuscardDeleteResponse : AopResponse
    {
        /// <summary>
        /// 如果学生学籍更新成功，则返回SUCCESS ， 失败返回FAIL。
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
