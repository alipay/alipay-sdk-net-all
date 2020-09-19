using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserFamilyArchiveQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserFamilyArchiveQueryModel : AopObject
    {
        /// <summary>
        /// 家人信息档案(选人授权)组件渲染请求令牌
        /// </summary>
        [XmlElement("archive_token")]
        public string ArchiveToken { get; set; }
    }
}
