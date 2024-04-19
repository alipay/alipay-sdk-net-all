using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenIotbpaasDevicebindApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenIotbpaasDevicebindApplyModel : AopObject
    {
        /// <summary>
        /// 绑定token，用于查询绑定状态
        /// </summary>
        [XmlElement("bind_token")]
        public string BindToken { get; set; }

        /// <summary>
        /// 非必传，传入为INIT时，强制生成新绑定token
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
