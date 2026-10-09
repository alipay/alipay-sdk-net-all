using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppOpenidApplyorderUploadResponse.
    /// </summary>
    public class AlipayOpenAppOpenidApplyorderUploadResponse : AopResponse
    {
        /// <summary>
        /// 非法的userid参数，说明部分参数不是有效的用户userid
        /// </summary>
        [XmlArray("illegal_user_id_list")]
        [XmlArrayItem("string")]
        public List<string> IllegalUserIdList { get; set; }
    }
}
