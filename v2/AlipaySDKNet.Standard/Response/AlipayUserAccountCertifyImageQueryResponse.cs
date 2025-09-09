using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserAccountCertifyImageQueryResponse.
    /// </summary>
    public class AlipayUserAccountCertifyImageQueryResponse : AopResponse
    {
        /// <summary>
        /// 用户证件图片数据
        /// </summary>
        [XmlArray("user_person_picture_detail")]
        [XmlArrayItem("user_person_picture_detail")]
        public List<UserPersonPictureDetail> UserPersonPictureDetail { get; set; }
    }
}
