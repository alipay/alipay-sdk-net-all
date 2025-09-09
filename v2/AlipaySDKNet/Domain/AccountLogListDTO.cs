using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AccountLogListDTO Data Structure.
    /// </summary>
    [Serializable]
    public class AccountLogListDTO : AopObject
    {
        /// <summary>
        /// 动作类型
        /// </summary>
        [XmlElement("action_type")]
        public string ActionType { get; set; }

        /// <summary>
        /// 余额, 单位为分
        /// </summary>
        [XmlElement("balance")]
        public string Balance { get; set; }

        /// <summary>
        /// 币种，CNY=人民币
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 业务流水号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 发生额,单位为分
        /// </summary>
        [XmlElement("trans_amount")]
        public string TransAmount { get; set; }

        /// <summary>
        /// 发生时间，格式yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("trans_time")]
        public string TransTime { get; set; }
    }
}
