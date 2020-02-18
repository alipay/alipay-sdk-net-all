using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserGradeAuthbaseQueryResponse.
    /// </summary>
    public class AlipayUserGradeAuthbaseQueryResponse : AopResponse
    {
        /// <summary>
        /// 用户的蚂蚁会员积分余额
        /// </summary>
        [XmlElement("balance")]
        public long Balance { get; set; }

        /// <summary>
        /// 用户的蚂蚁会员等级
        /// </summary>
        [XmlElement("grade")]
        public string Grade { get; set; }
    }
}
