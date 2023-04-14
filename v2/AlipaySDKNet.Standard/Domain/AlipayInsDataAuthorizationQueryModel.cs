using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsDataAuthorizationQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsDataAuthorizationQueryModel : AopObject
    {
        /// <summary>
        /// 授权业务唯一单号 投保场景为保单号；理赔场景为报案号。
        /// </summary>
        [XmlElement("auth_biz_no")]
        public string AuthBizNo { get; set; }

        /// <summary>
        /// 机构编码
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 授权场景码。枚举值： 1-投保，2-理赔
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }
    }
}
