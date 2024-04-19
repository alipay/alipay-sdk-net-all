using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppJfSignprocessQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppJfSignprocessQueryModel : AopObject
    {
        /// <summary>
        /// 生活缴费代扣签约用户UID, 需要和异步签约的用户UID保持一致
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部业务号, 必须和异步签约申请的外部流水号保持一致
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 异步签约流程ID
        /// </summary>
        [XmlElement("process_id")]
        public string ProcessId { get; set; }

        /// <summary>
        /// 生活缴费代扣签约用户UID, 需要和异步签约的用户UID保持一致
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
