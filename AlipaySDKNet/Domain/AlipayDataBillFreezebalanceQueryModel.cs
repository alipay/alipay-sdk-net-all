using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataBillFreezebalanceQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataBillFreezebalanceQueryModel : AopObject
    {
        /// <summary>
        /// 目标查询用户uid
        /// </summary>
        [XmlElement("bill_user_id")]
        public string BillUserId { get; set; }

        /// <summary>
        /// 冻结类型
        /// </summary>
        [XmlElement("freeze_type")]
        public string FreezeType { get; set; }
    }
}
