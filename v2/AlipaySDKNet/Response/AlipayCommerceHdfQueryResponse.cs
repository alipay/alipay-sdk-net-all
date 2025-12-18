using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceHdfQueryResponse.
    /// </summary>
    public class AlipayCommerceHdfQueryResponse : AopResponse
    {
        /// <summary>
        /// 好大夫的用户id
        /// </summary>
        [XmlElement("hdf_user_id")]
        public string HdfUserId { get; set; }
    }
}
