using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalFincloudGeneralsaasFaceCheckQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalFincloudGeneralsaasFaceCheckQueryModel : AopObject
    {
        /// <summary>
        /// 传入初始化接口datadigital.fincloud.generalsaas.face.check.initialize 得到的certify_id
        /// </summary>
        [XmlElement("certify_id")]
        public string CertifyId { get; set; }

        /// <summary>
        /// 是否需要返回活体结果图片，needAlivePhoto：Y_O （原始图片）、Y_M（虚化，背景马赛克）、N（不返图）。非必填，默认为N
        /// </summary>
        [XmlElement("need_alive_photo")]
        public string NeedAlivePhoto { get; set; }

        /// <summary>
        /// 该参数已废弃
        /// </summary>
        [XmlElement("need_attack_result")]
        public string NeedAttackResult { get; set; }

        /// <summary>
        /// 是否需要返回图片质量分，非必填，默认值为N。 N表示不需要，Y表示需要
        /// </summary>
        [XmlElement("need_quality_score")]
        public string NeedQualityScore { get; set; }

        /// <summary>
        /// 该入参已经废弃。
        /// </summary>
        [XmlElement("need_score")]
        public string NeedScore { get; set; }
    }
}
