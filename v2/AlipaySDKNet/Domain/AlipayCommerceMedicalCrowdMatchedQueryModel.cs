using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalCrowdMatchedQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalCrowdMatchedQueryModel : AopObject
    {
        /// <summary>
        /// 查询某一应用人群包的渠道码
        /// </summary>
        [XmlElement("crowd_code")]
        public string CrowdCode { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 支付宝uid，2088开头的16位纯数字，小程序场景下获取用户ID请参考：用户授权; 其它场景下获取用户ID请参考：网页授权获取用户信息;
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
