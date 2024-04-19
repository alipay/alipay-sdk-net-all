using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudrunObjectstoragePermissionModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudrunObjectstoragePermissionModifyModel : AopObject
    {
        /// <summary>
        /// 环境ID，唯一，开通小程序云系统会生成环境ID，请从开通页面获取
        /// </summary>
        [XmlElement("env")]
        public string Env { get; set; }

        /// <summary>
        /// 实例的读权限
        /// </summary>
        [XmlElement("read_permission")]
        public string ReadPermission { get; set; }
    }
}
