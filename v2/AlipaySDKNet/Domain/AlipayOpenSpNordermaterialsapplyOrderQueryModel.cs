using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSpNordermaterialsapplyOrderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSpNordermaterialsapplyOrderQueryModel : AopObject
    {
        /// <summary>
        /// 此前接口创建申请单时，蚂蚁侧返回的申请单ID
        /// </summary>
        [XmlElement("apply_id")]
        public string ApplyId { get; set; }
    }
}
