using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateSceneTokenApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateSceneTokenApplyModel : AopObject
    {
        /// <summary>
        /// 业务场景
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 用户详细信息
        /// </summary>
        [XmlElement("user_detail_info")]
        public UserDetailDto UserDetailInfo { get; set; }
    }
}
