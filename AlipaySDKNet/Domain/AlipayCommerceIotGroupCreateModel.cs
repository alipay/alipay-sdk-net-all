using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceIotGroupCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotGroupCreateModel : AopObject
    {
        /// <summary>
        /// 业务类型-代表不同的业务场景 distribution表示服务分发
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 分组描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 分组名称
        /// </summary>
        [XmlElement("group_name")]
        public string GroupName { get; set; }
    }
}
