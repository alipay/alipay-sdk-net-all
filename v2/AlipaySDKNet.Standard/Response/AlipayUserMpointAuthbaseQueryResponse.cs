using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserMpointAuthbaseQueryResponse.
    /// </summary>
    public class AlipayUserMpointAuthbaseQueryResponse : AopResponse
    {
        /// <summary>
        /// 支付宝用户的蚂蚁会员积分余额
        /// </summary>
        [XmlElement("balance")]
        public long Balance { get; set; }

        /// <summary>
        /// 支付宝用户的蚂蚁会员等级
        /// </summary>
        [XmlElement("grade")]
        public string Grade { get; set; }

        /// <summary>
        /// 会员的联名身份
        /// </summary>
        [XmlArray("joint_info")]
        [XmlArrayItem("string")]
        public List<string> JointInfo { get; set; }
    }
}
