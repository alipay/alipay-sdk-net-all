using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserAuthenticationTokenSaveModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAuthenticationTokenSaveModel : AopObject
    {
        /// <summary>
        /// 业务码
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 业务暂存数据
        /// </summary>
        [XmlElement("biz_obj")]
        public string BizObj { get; set; }
    }
}
