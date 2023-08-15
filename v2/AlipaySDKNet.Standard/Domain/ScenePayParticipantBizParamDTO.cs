using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ScenePayParticipantBizParamDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ScenePayParticipantBizParamDTO : AopObject
    {
        /// <summary>
        /// 由各业务场景定义，具体参考场景解决方案接入文档
        /// </summary>
        [XmlElement("authorization_id")]
        public string AuthorizationId { get; set; }

        /// <summary>
        /// 外部卡号
        /// </summary>
        [XmlElement("out_card_no")]
        public string OutCardNo { get; set; }
    }
}
