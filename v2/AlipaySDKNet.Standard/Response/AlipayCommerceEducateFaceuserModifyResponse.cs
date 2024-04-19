using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateFaceuserModifyResponse.
    /// </summary>
    public class AlipayCommerceEducateFaceuserModifyResponse : AopResponse
    {
        /// <summary>
        /// 失败人脸信息列表。（1.如果响应code为10000，忽略当前字段；2.服务商可以根据retry来重试部分用户；3.其他失败用户，需要根据具体返回纠正字段，或联系技术同学支持；）
        /// </summary>
        [XmlArray("fail_user_list")]
        [XmlArrayItem("fail_face_user_info")]
        public List<FailFaceUserInfo> FailUserList { get; set; }
    }
}
