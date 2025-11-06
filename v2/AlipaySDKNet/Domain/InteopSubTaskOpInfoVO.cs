using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InteopSubTaskOpInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class InteopSubTaskOpInfoVO : AopObject
    {
        /// <summary>
        /// 作业子单取消失败备注信息
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 作业子单号
        /// </summary>
        [XmlElement("sub_order_no")]
        public string SubOrderNo { get; set; }
    }
}
