using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ScenePayToken Data Structure.
    /// </summary>
    [Serializable]
    public class ScenePayToken : AopObject
    {
        /// <summary>
        /// 场景支付凭证
        /// </summary>
        [XmlElement("scene_pay_token")]
        public string ScenePayToken_ { get; set; }

        /// <summary>
        /// 场景支付二维码
        /// </summary>
        [XmlElement("scene_pay_token_type")]
        public string ScenePayTokenType { get; set; }
    }
}
