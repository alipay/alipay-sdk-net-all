using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSearchAppkeywordQuerystatusModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSearchAppkeywordQuerystatusModel : AopObject
    {
        /// <summary>
        /// 审核工单id，提报接口的返回值
        /// </summary>
        [XmlElement("apply_no")]
        public string ApplyNo { get; set; }

        /// <summary>
        /// 小程序id
        /// </summary>
        [XmlElement("target_appid")]
        public string TargetAppid { get; set; }
    }
}
