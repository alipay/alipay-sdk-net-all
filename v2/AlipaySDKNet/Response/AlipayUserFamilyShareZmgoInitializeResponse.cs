using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserFamilyShareZmgoInitializeResponse.
    /// </summary>
    public class AlipayUserFamilyShareZmgoInitializeResponse : AopResponse
    {
        /// <summary>
        /// 共享组件链接
        /// </summary>
        [XmlElement("family_sharing_link")]
        public string FamilySharingLink { get; set; }

        /// <summary>
        /// 是否已经存在共享关系
        /// </summary>
        [XmlElement("has_sharing")]
        public bool HasSharing { get; set; }

        /// <summary>
        /// 是否可共享
        /// </summary>
        [XmlElement("shareable")]
        public bool Shareable { get; set; }
    }
}
