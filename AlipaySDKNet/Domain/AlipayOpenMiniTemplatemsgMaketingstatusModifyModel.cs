using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniTemplatemsgMaketingstatusModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniTemplatemsgMaketingstatusModifyModel : AopObject
    {
        /// <summary>
        /// 营销投放详情id
        /// </summary>
        [XmlElement("detail_id")]
        public string DetailId { get; set; }

        /// <summary>
        /// 投放详情状态值，如：INIT:下线状态，ON_LINE:上线状态，DELETED:删除状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
