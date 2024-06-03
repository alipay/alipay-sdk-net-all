using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceBillEventTriggerModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceBillEventTriggerModel : AopObject
    {
        /// <summary>
        /// 账单ID列表，账单ID格式由各机构自己定义即可，若填写则仅针对指定的账单ID推送还款消息，否则推送该用户下所有的还款消息
        /// </summary>
        [XmlArray("bill_id_list")]
        [XmlArrayItem("string")]
        public List<string> BillIdList { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
