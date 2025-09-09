using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AcceptInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class AcceptInfoVO : AopObject
    {
        /// <summary>
        /// 订单的受理模式，租赁类型订单且通过交易组件快捷下单场景特有
        /// </summary>
        [XmlElement("accept_mode")]
        public string AcceptMode { get; set; }

        /// <summary>
        /// 人脸核身结果
        /// </summary>
        [XmlElement("verify_result")]
        public string VerifyResult { get; set; }
    }
}
