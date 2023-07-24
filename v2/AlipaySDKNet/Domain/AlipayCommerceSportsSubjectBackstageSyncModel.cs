using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceSportsSubjectBackstageSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceSportsSubjectBackstageSyncModel : AopObject
    {
        /// <summary>
        /// 主题列表
        /// </summary>
        [XmlElement("list")]
        public AIDongSubjectSyncDetail List { get; set; }
    }
}
