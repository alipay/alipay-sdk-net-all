using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateFaceuserModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateFaceuserModifyModel : AopObject
    {
        /// <summary>
        /// 业务码。可选的场景码有：{TRAFFIC:出行行业，BUSINESS:企业行业，SCENIC:景区行业，COMMUNITY:社区行业}
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 人脸库id。
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 人脸库要修改的用户信息列表。（注意：当前人脸列表不宜过长，目前最大支持仅支持50）
        /// </summary>
        [XmlArray("user_list")]
        [XmlArrayItem("tiny_face_user_info")]
        public List<TinyFaceUserInfo> UserList { get; set; }
    }
}
