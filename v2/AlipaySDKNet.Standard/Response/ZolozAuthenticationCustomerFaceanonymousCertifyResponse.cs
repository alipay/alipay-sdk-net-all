using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZolozAuthenticationCustomerFaceanonymousCertifyResponse.
    /// </summary>
    public class ZolozAuthenticationCustomerFaceanonymousCertifyResponse : AopResponse
    {
        /// <summary>
        /// true攻击，false不是攻击
        /// </summary>
        [XmlElement("attack")]
        public bool Attack { get; set; }

        /// <summary>
        /// 人脸相似度误识率阈值，小数形式代表的概率值，例如万分之一
        /// </summary>
        [XmlElement("far_threshold")]
        public string FarThreshold { get; set; }

        /// <summary>
        /// 0-100的Float类型的分数值，活体图综合质量分
        /// </summary>
        [XmlElement("joint_quality")]
        public string JointQuality { get; set; }

        /// <summary>
        /// 0-100的int类型分数值，非本人人脸相似度阈值(精度损失仅整数)，小于等于阈值为不是同一个人，大于阈值并且小于等于sameFaceThreshold为不确定
        /// </summary>
        [XmlElement("not_same_face_threshold")]
        public string NotSameFaceThreshold { get; set; }

        /// <summary>
        /// true比对通过，false比对不通过
        /// </summary>
        [XmlElement("passed")]
        public bool Passed { get; set; }

        /// <summary>
        /// 0-100的int类型的分数值，人脸相似度阈值(精度损失仅整数)，大于阈值为Y，即同一个人，小于等于阈值并且大于notSameFaceThreshold为不确定
        /// </summary>
        [XmlElement("same_face_threshold")]
        public string SameFaceThreshold { get; set; }

        /// <summary>
        /// 0-100的Double类型，可留底质量分阈值
        /// </summary>
        [XmlElement("server_min_quality")]
        public string ServerMinQuality { get; set; }

        /// <summary>
        /// 0-100的Double类型的分数值，比对的相似度得分
        /// </summary>
        [XmlElement("similarity")]
        public string Similarity { get; set; }
    }
}
