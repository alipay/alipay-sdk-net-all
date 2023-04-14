using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserCertifyVerificationQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserCertifyVerificationQueryModel : AopObject
    {
        /// <summary>
        /// 算法识别出来的年龄，double类型
        /// </summary>
        [XmlElement("age")]
        public string Age { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [XmlElement("cert_name")]
        public string CertName { get; set; }

        /// <summary>
        /// 证件号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 误识率
        /// </summary>
        [XmlElement("far")]
        public string Far { get; set; }

        /// <summary>
        /// 算法预测的年龄；[0,0.5) 女性，(0.5,正无穷)男性
        /// </summary>
        [XmlElement("gender_score")]
        public string GenderScore { get; set; }

        /// <summary>
        /// 人脸图像，jpg格式，BASE64转换后字符串，大小限制为30K以内
        /// </summary>
        [XmlElement("portrait")]
        public string Portrait { get; set; }

        /// <summary>
        /// 人脸区域坐标，格式为：left,top,right,bottom
        /// </summary>
        [XmlElement("portrait_auth_rect")]
        public string PortraitAuthRect { get; set; }

        /// <summary>
        /// 核验网络场景码
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }
    }
}
