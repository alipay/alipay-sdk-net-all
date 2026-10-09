using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BusinessParamsMap Data Structure.
    /// </summary>
    [Serializable]
    public class BusinessParamsMap : AopObject
    {
        /// <summary>
        /// 服务变更时间
        /// </summary>
        [XmlElement("change_time")]
        public string ChangeTime { get; set; }

        /// <summary>
        /// 服务变更后新金额
        /// </summary>
        [XmlElement("new_amount")]
        public string NewAmount { get; set; }

        /// <summary>
        /// 原始价格
        /// </summary>
        [XmlElement("ori_amount")]
        public string OriAmount { get; set; }
    }
}
