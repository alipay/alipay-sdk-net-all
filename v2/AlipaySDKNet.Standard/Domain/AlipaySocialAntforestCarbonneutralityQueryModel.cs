using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySocialAntforestCarbonneutralityQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialAntforestCarbonneutralityQueryModel : AopObject
    {
        /// <summary>
        /// 蚂蚁统一会员ID，执行该查询操作的支付宝用户
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
