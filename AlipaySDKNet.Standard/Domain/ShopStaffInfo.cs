using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ShopStaffInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ShopStaffInfo : AopObject
    {
        /// <summary>
        /// 服务人员描述
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 工作人员名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 服务人员照片
        /// </summary>
        [XmlElement("picture")]
        public string Picture { get; set; }
    }
}
