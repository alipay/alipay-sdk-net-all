using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateFacepayApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateFacepayApplyModel : AopObject
    {
        /// <summary>
        /// 扩展信息, json格式. 例如, 对不使用银行代扣, 可以传入{"useBankChannel":"NO"}； 使用银行代扣且指定银行，{"useBankChannel":"YES","useBankMode":"BANK"}； 使用银行代扣且指定银行卡，{"useBankChannel":"YES","useBankMode":"BANK_CARD"}。且必须实现获取银行卡信息的SPIAPI，若不传useBankMode默认指定银行
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 刷脸用户openId
        /// </summary>
        [XmlElement("face_open_id")]
        public string FaceOpenId { get; set; }

        /// <summary>
        /// 刷脸用户id
        /// </summary>
        [XmlElement("face_uid")]
        public string FaceUid { get; set; }

        /// <summary>
        /// 接入场景，可选项： K12   --  K12场景 COLLEGE  --  高校场景
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 学校外标
        /// </summary>
        [XmlElement("school_stdcode")]
        public string SchoolStdcode { get; set; }
    }
}
