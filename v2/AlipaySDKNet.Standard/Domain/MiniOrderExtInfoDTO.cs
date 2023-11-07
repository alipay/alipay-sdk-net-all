using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MiniOrderExtInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class MiniOrderExtInfoDTO : AopObject
    {
        /// <summary>
        /// 预约上门取件的时间,格式为  yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("door_time")]
        public string DoorTime { get; set; }

        /// <summary>
        /// 芝麻免押冻结资金签名串，调用 <a href="https://opendocs.alipay.com/open/e2e70da4_alipay.fund.auth.order.app.freeze?pathHash=1002681c&ref=api">alipay.fund.auth.order.app.freeze</a>生成，用于租赁场景冻结授权资金
        /// </summary>
        [XmlElement("order_str")]
        public string OrderStr { get; set; }
    }
}
