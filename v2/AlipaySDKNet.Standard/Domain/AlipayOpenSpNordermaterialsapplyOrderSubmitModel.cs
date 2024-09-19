using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSpNordermaterialsapplyOrderSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSpNordermaterialsapplyOrderSubmitModel : AopObject
    {
        /// <summary>
        /// 此前接口蚂蚁侧返回的创建申请单ID
        /// </summary>
        [XmlElement("apply_id")]
        public string ApplyId { get; set; }
    }
}
